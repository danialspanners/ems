Option Explicit On 

Imports System.Data
Imports System.Data.SqlClient
Imports DataAccess.DAccess

Namespace SystemBusRules

    Public Class EnclosureBusLogic
#Region " Enclosure Type Variable "
        Private mvarEnclosure_Id As Integer
        Private mvarEnclosure_Type As String
        Private mvarMarkup_Factor As Double
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As String
#End Region

#Region " Enclosure Function "
        Public Function GetEnclosureType(ByRef ds As DataSet, Optional ByVal pEnclosure_Id As String = "") As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                If Len(pEnclosure_Id) > 0 Then
                    SQLStr = "SELECT * FROM EnclosureType where Enclosure_Id = " & Integer.Parse(pEnclosure_Id)
                Else
                    SQLStr = "SELECT * FROM EnclosureType "
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Function GetMarkupFactor(ByVal pEnclosure_Id As String) As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String
                Dim ds As DataSet

                SQLStr = "SELECT * FROM EnclosureType where Enclosure_Id = " & Integer.Parse(pEnclosure_Id)

                If .GetDataSet(ds, SQLStr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        mvarMarkup_Factor = ds.Tables(0).Rows(0)("Markup_Factor")
                        Return True
                    Else
                        Return False
                    End If
                End If
                ds.Dispose()
            End With
        End Function

        Public Function SaveEnclosureType() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "SET DATEFORMAT DMY;INSERT INTO EnclosureType "
            SQLStr = SQLStr & "(Enclosure_Type,Markup_Factor,Create_Date,Transact_Date,UserID)"
            SQLStr = SQLStr & " VALUES ('" & mvarEnclosure_Type & "'," & mvarMarkup_Factor & ", GetDate(),GetDate(),"
            SQLStr = SQLStr & mvarUserID & ")"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Sub UpdateEnclosure(ByVal pEnclosure_Id As String)

            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy; Update EnclosureType set "
            strSQL = strSQL & " Transact_Date=GetDate(),"
            strSQL = strSQL & " Enclosure_Type= '" & Replace(mvarEnclosure_Type, "'", "''") & "',"
            strSQL = strSQL & " Markup_Factor= " & mvarMarkup_Factor
            strSQL = strSQL & " WHERE Enclosure_Id = " & pEnclosure_Id

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                End If
            End With
            ds.Dispose()

        End Sub

        Public Function DeleteEnclosureType() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "DELETE FROM EnclosureType WHERE Enclosure_Id = " & mvarEnclosure_Id

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function
#End Region

#Region " Enclosure Get n Set Statement "
        Public Property Enclosure_Id() As Integer
            Get
                Return mvarEnclosure_Id
            End Get
            Set(ByVal Value As Integer)
                mvarEnclosure_Id = Value
            End Set
        End Property

        Public Property Enclosure_Type() As String
            Get
                Return mvarEnclosure_Type
            End Get
            Set(ByVal Value As String)
                mvarEnclosure_Type = Value
            End Set
        End Property

        Public Property Markup_Factor() As Double
            Get
                Return mvarMarkup_Factor
            End Get
            Set(ByVal Value As Double)
                mvarMarkup_Factor = Value
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

    Public Class DocumentNumberBusLogic
#Region " Document Number Variable "
        Private mvarDocumentID As Integer
        Private mvarDocumentCode As String
        Private mvarDocumentNextNumber As Integer
        Private mvarIncrementValue As Integer
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As String
#End Region

#Region " Document Number Function "
        Public Function GetDocumentNumber(ByRef ds As DataSet, Optional ByVal pDocumentCode As String = "") As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                If Len(pDocumentCode) > 0 Then
                    SQLStr = "SELECT * FROM DocumentNumber where DocumentCode = " & Integer.Parse(pDocumentCode)
                Else
                    SQLStr = "SELECT * FROM DocumentNumber "
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetDocumentNumber(ByVal pDocumentCode As String) As String
            Dim ds As DataSet
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                SQLStr = "SELECT * FROM DocumentNumber where DocumentCode = " & Integer.Parse(pDocumentCode)
                If ds.Tables(0).Rows.Count > 0 Then
                    GetDocumentNumber = ds.Tables(0).Rows(0)("DocumentNextNumber")
                Else
                    GetDocumentNumber = ""
                End If

            End With
        End Function

        Public Function UpdateDocumentNumber() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "SET DATEFORMAT DMY;UPDATE DocumentNumber SET "
            SQLStr = SQLStr & " DocumentNextNumber = " & mvarDocumentNextNumber & ","
            SQLStr = SQLStr & " IncrementValue = " & mvarIncrementValue & ","
            SQLStr = SQLStr & " Transact_Date = GetDate(),"
            SQLStr = SQLStr & " UserID = '" & mvarUserID & "'"
            SQLStr = SQLStr & " WHERE DocumentCode = '" & mvarDocumentCode & "'"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function
#End Region

#Region " Document Number Get n Set Statement "
        Public Property DocumentID() As Integer
            Get
                Return mvarDocumentID
            End Get
            Set(ByVal Value As Integer)
                mvarDocumentID = Value
            End Set
        End Property

        Public Property DocumentCode() As String
            Get
                Return mvarDocumentCode
            End Get
            Set(ByVal Value As String)
                mvarDocumentCode = Value
            End Set
        End Property

        Public Property DocumentNextNumber() As Integer
            Get
                Return mvarDocumentNextNumber
            End Get
            Set(ByVal Value As Integer)
                mvarDocumentNextNumber = Value
            End Set
        End Property

        Public Property IncrementValue() As Integer
            Get
                Return mvarIncrementValue
            End Get
            Set(ByVal Value As Integer)
                mvarIncrementValue = Value
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

    Public Class LVBBoxBusLogic
#Region " LVB Variable "
        Private mvarBox_Type_Id As Integer
        Private mvarBox_Name As String
        Private mvarDescription As String
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As Integer
#End Region

#Region " Function "
        Public Function GetLVBBox(ByRef ds As DataSet, Optional ByVal pBox_Type_Id As String = "") As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                If Len(pBox_Type_Id) > 0 Then
                    SQLStr = "SELECT * FROM LVBBox where Box_Type_Id = " & Integer.Parse(pBox_Type_Id)
                Else
                    SQLStr = "SELECT * FROM LVBBox "
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        'Public Function SaveLVBBox() As Boolean
        '    Dim ds As DataSet
        '    Dim SQLStr As String = "SET DATEFORMAT DMY;INSERT INTO LVBBox "
        '   SQLStr = SQLStr & "(Box_Name,Description,Create_Date,Transact_Date,UserID)"
        '  SQLStr = SQLStr & " VALUES ('" & mvarBox_Name & "', '" & mvarDescription & "',GetDate(),GetDate(),"
        ' SQLStr = SQLStr & mvarUserID & ")"

        'With New DataAccess.DAccess.Access
        '   If .GetDataSet(ds, SQLStr) Then
        '      Return True
        ' End If
        'ds.Dispose()
        'End With
        'End Function

        'Public Sub UpdateLVBBox(ByVal pBox_Type_Id As String)
        '    Dim strSQL As String
        '   Dim ds As DataSet

        '  strSQL = "Set dateformat dmy; Update LVBBox set "
        ' strSQL = strSQL & " Transact_Date=GetDate(),"
        'strSQL = strSQL & " Box_Name= '" & Replace(mvarBox_Name, "'", "''") & "'"
        'strSQL = strSQL & " Description= '" & Replace(mvarDescription, "'", "''") & "'"
        'strSQL = strSQL & " WHERE Box_Type_Id = " & pBox_Type_Id

        'With New DataAccess.DAccess.Access
        '   If .GetDataSet(ds, strSQL) Then
        '  End If
        'End With
        'ds.Dispose()
        'End Sub

        'Public Function DeleteLVBBox() As Boolean
        '   Dim ds As DataSet
        '  Dim SQLStr As String = "DELETE FROM LVBBox WHERE Box_Type_Id = " & mvarBox_Type_Id

        ' With New DataAccess.DAccess.Access
        '    If .GetDataSet(ds, SQLStr) Then
        '       Return True
        '  End If
        ' ds.Dispose()
        'End With
        'End Function

        Public Function Save() As Integer
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy;INSERT INTO LVBBox("
            strSQL = strSQL & "Box_Name, Description, Create_Date, Transact_Date, UserID "
            strSQL = strSQL & ") VALUES("

            If Len(mvarBox_Name) > 0 Then
                strSQL = strSQL & " '" & Replace(mvarBox_Name, "'", "''") & "',"

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

            strSQL = strSQL & "(SELECT @@IDENTITY AS Box_Type_Id from LVBBox)"

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

        Public Sub Delete(ByVal pBox_Type_Id As String)
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy;DELETE FROM LVBBox"
            strSQL = strSQL & " WHERE Box_Type_Id=" & pBox_Type_Id

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                End If
            End With
            ds.Dispose()
        End Sub

        Public Sub Update(ByVal pBox_Type_Id As String)

            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy; Update LVBBox set "
            strSQL = strSQL & " Transact_Date=GetDate(),"

            If Len(mvarBox_Name) > 0 Then
                strSQL = strSQL & " Box_Name= '" & Replace(mvarBox_Name, "'", "''") & "',"
            Else
                strSQL = strSQL & " Box_Name= NULL,"
            End If

            If Len(mvarDescription) > 0 Then
                strSQL = strSQL & " Description= '" & Replace(mvarDescription, "'", "''") & "'"
            Else
                strSQL = strSQL & " Description= NULL"
            End If

            strSQL = strSQL & " WHERE Box_Type_Id = " & pBox_Type_Id

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                End If
            End With
            ds.Dispose()

        End Sub

        Public Function LoadList(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "SELECT * FROM LVBBox "

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If

            End With
        End Function

        Public Function LoadList2(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "SELECT Box_Type_Id, Box_Name + ' - ' + Description As Box_Name FROM LVBBox "

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If

            End With
        End Function

        Public Function Load(ByVal pBox_Type_Id As Integer) As Boolean
            With New DataAccess.DAccess.Access
                Dim ds As DataSet
                Dim SQLStr As String = "SELECT * FROM LVBBox"

                SQLStr = SQLStr & " WHERE Box_Type_Id =" & pBox_Type_Id

                If .GetDataSet(ds, SQLStr) Then
                    Dim row As DataRow = ds.Tables(0).Rows(0)

                    If Not row.IsNull("Box_Name") Then
                        Box_Name = row("Box_Name").ToString()
                    Else
                        Box_Name = ""
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

        Public Function RecordExists(ByVal pBox_Name As String, Optional ByVal pBox_Type_Id As Integer = Nothing) As Boolean

            Dim ds As DataSet
            Dim SQLStr As String
            SQLStr = "SELECT Box_Type_Id FROM LVBBox"
            SQLStr = SQLStr & " WHERE Box_Name='" & pBox_Name & "'"

            If pBox_Type_Id <> Nothing And pBox_Type_Id <> 0 Then
                SQLStr = SQLStr & " AND Box_Type_Id<>" & pBox_Type_Id
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

#Region " LVB Get n Set Statement "
        Public Property Box_Type_Id() As Integer
            Get
                Return mvarBox_Type_Id
            End Get
            Set(ByVal Value As Integer)
                mvarBox_Type_Id = Value
            End Set
        End Property

        Public Property Box_Name() As String
            Get
                Return mvarBox_Name
            End Get
            Set(ByVal Value As String)
                mvarBox_Name = Value
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

    Public Class SectionBusLogic
#Region " Section Variable "
        Private mvarSection_Id As Integer
        Private mvarSection_Code As String
        Private mvarSection_Code_Match As String
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As String
#End Region

#Region " Section Function "
        Public Function GetSection(ByRef ds As DataSet, Optional ByVal pSection_Id As String = "") As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                If Len(pSection_Id) > 0 Then
                    SQLStr = "SELECT * FROM Section where Section_Id = " & Integer.Parse(pSection_Id)
                Else
                    SQLStr = "SELECT * FROM Section "
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function
#End Region

#Region " Section Get n Set Statement "
        Public Property Section_Id() As Integer
            Get
                Return mvarSection_Id
            End Get
            Set(ByVal Value As Integer)
                mvarSection_Id = Value
            End Set
        End Property

        Public Property Section_Code() As String
            Get
                Return mvarSection_Code
            End Get
            Set(ByVal Value As String)
                mvarSection_Code = Value
            End Set
        End Property

        Public Property Section_Code_Match() As String
            Get
                Return mvarSection_Code_Match
            End Get
            Set(ByVal Value As String)
                mvarSection_Code_Match = Value
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

    Public Class ProjectBusLogic
#Region " Project Variable "
        Private mvarProject_ID As Integer
        Private mvarProject_Name As String
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As String
#End Region

#Region " Project Function "
        Public Function GetProject(ByRef ds As DataSet, Optional ByVal pProject_ID As String = "") As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                If Len(pProject_ID) > 0 Then
                    SQLStr = "SELECT * FROM Project where Project_ID = " & Integer.Parse(pProject_ID)
                Else
					SQLStr = "SELECT * FROM Project order by project_Name asc "
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                '## Added by Andrew
                ds.Dispose()
                '## End
            End With
        End Function

        Public Function SaveProject() As Integer
            Dim ds As DataSet
            Dim SQLStr As String = "SET DATEFORMAT DMY;INSERT INTO Project "
            SQLStr = SQLStr & "(Project_Name,Create_Date,Transact_Date,UserID)"
            SQLStr = SQLStr & " VALUES ('" & mvarProject_Name & "', GetDate(),GetDate(),"
            SQLStr = SQLStr & mvarUserID & ")"
            SQLStr = SQLStr & ";(select @@IDENTITY as Project_ID from Project)"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    If ds.Tables(0).Rows.Count = 0 Then
                        Return Nothing
                    Else
                        Return Integer.Parse(ds.Tables(0).Rows(0).Item(0).ToString)
                    End If
                Else
                    Return Nothing
                End If
                ds.Dispose()
            End With
        End Function

        Public Sub UpdateProject(ByVal pProject_ID As String)
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy; Update Project set "
            strSQL = strSQL & " Transact_Date=GetDate(),"
            strSQL = strSQL & " Project_Name= '" & Replace(mvarProject_Name, "'", "''") & "'"
            strSQL = strSQL & " WHERE Project_ID = " & pProject_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                End If
            End With
            ds.Dispose()

        End Sub

        Public Function DeleteProject() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "DELETE FROM Project WHERE Project_ID = " & mvarProject_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Function IsProjectNameInUsed(ByVal pProject_ID As Integer) As Boolean
            With New DataAccess.DAccess.Access
                Dim ds As DataSet
                Dim SQLStr As String

                SQLStr = "SELECT * FROM QuotationHeader where Project = " & Integer.Parse(pProject_ID)

                If .GetDataSet(ds, SQLStr) Then
                    If Not ds Is Nothing Then
                        If ds.Tables(0).Rows.Count > 0 Then
                            Return True
                        Else
                            SQLStr = "SELECT * FROM WorkOrderHeader where Project = " & Integer.Parse(pProject_ID)
                            If .GetDataSet(ds, SQLStr) Then
                                If Not ds Is Nothing Then
                                    If ds.Tables(0).Rows.Count > 0 Then
                                        Return True
                                    Else
                                        Return False
                                    End If
                                Else
                                    Return False
                                End If
                            End If
                        End If
                    Else
                        Return False
                    End If
                End If
                ds.Dispose()
            End With
        End Function
#End Region

#Region " Project Get n Set Statement "
        Public Property Project_ID() As Integer
            Get
                Return mvarProject_ID
            End Get
            Set(ByVal Value As Integer)
                mvarProject_ID = Value
            End Set
        End Property

        Public Property Project_Name() As String
            Get
                Return mvarProject_Name
            End Get
            Set(ByVal Value As String)
                mvarProject_Name = Value
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

    Public Class ConsultantBusLogic
#Region " Consultant Variable "
        Private mvarConsultant_ID As Integer
        Private mvarConsultant_Name As String
        Private mvarAccount_No As String
        Private mvarAddress As String
        Private mvarCountry As String
        Private mvarTel As String
        Private mvarFax As String
        Private mvarRemark As String
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As String
#End Region

#Region " Consultant Function "
        Public Function GetConsultant(ByRef ds As DataSet, Optional ByVal pConsultant_ID As String = "") As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                If Len(pConsultant_ID) > 0 Then
                    SQLStr = "SELECT * FROM Consultant where Consultant_ID = " & Integer.Parse(pConsultant_ID)
                Else
                    SQLStr = "SELECT * FROM Consultant "
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function
#End Region

#Region " Consultant Get n Set Statement "
        Public Property Consultant_ID() As Integer
            Get
                Return mvarConsultant_ID
            End Get
            Set(ByVal Value As Integer)
                mvarConsultant_ID = Value
            End Set
        End Property

        Public Property Consultant_Name() As String
            Get
                Return mvarConsultant_Name
            End Get
            Set(ByVal Value As String)
                mvarConsultant_Name = Value
            End Set
        End Property

        Public Property Address() As String
            Get
                Return mvarAddress
            End Get
            Set(ByVal Value As String)
                mvarAddress = Value
            End Set
        End Property

        Public Property Country() As String
            Get
                Return mvarCountry
            End Get
            Set(ByVal Value As String)
                mvarCountry = Value
            End Set
        End Property

        Public Property Tel() As String
            Get
                Return mvarTel
            End Get
            Set(ByVal Value As String)
                mvarTel = Value
            End Set
        End Property

        Public Property Fax() As String
            Get
                Return mvarFax
            End Get
            Set(ByVal Value As String)
                mvarFax = Value
            End Set
        End Property

        Public Property Remark() As String
            Get
                Return mvarRemark
            End Get
            Set(ByVal Value As String)
                mvarRemark = Value
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

    Public Class PriceIncludeBusLogic
#Region " Price Include Variable "
        Private mvarPriceInclude_ID As Integer
        Private mvarPriceInclude_Name As String
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As String
#End Region

#Region " Price Include Function "
        Public Function GetPriceInclude(ByRef ds As DataSet, Optional ByVal pPriceInclude_ID As String = "") As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                If Len(pPriceInclude_ID) > 0 Then
                    SQLStr = "SELECT * FROM PriceInclude where PriceInclude_ID = " & Integer.Parse(pPriceInclude_ID)
                Else
                    SQLStr = "SELECT * FROM PriceInclude "
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Function GetPriceIncludeForEdit(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String = "SELECT * FROM PriceInclude WHERE (PriceInclude_Name <> '')"

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function SavePriceInclude() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "SET DATEFORMAT DMY;INSERT INTO PriceInclude "
            SQLStr = SQLStr & "(PriceInclude_Name,Create_Date,Transact_Date,UserID)"
            SQLStr = SQLStr & " VALUES ('" & mvarPriceInclude_Name & "', GetDate(),GetDate(),"
            SQLStr = SQLStr & mvarUserID & ")"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Sub UpdatePriceInclude(ByVal pPriceInclude_ID As String)
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy; Update PriceInclude set "
            strSQL = strSQL & " Transact_Date=GetDate(),"
            strSQL = strSQL & " PriceInclude_Name= '" & Replace(mvarPriceInclude_Name, "'", "''") & "'"
            strSQL = strSQL & " WHERE PriceInclude_ID = " & pPriceInclude_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                End If
            End With
            ds.Dispose()

        End Sub

        Public Function DeletePriceInclude() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "DELETE FROM PriceInclude WHERE PriceInclude_ID = " & mvarPriceInclude_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function
#End Region

#Region " Price Include Get n Set Statement "
        Public Property PriceInclude_ID() As Integer
            Get
                Return mvarPriceInclude_ID
            End Get
            Set(ByVal Value As Integer)
                mvarPriceInclude_ID = Value
            End Set
        End Property

        Public Property PriceInclude_Name() As String
            Get
                Return mvarPriceInclude_Name
            End Get
            Set(ByVal Value As String)
                mvarPriceInclude_Name = Value
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

    Public Class BoxCategoryBusLogic
#Region " Box Category Variable "
        Private mvarBoxCategory_ID As Integer
        Private mvarBoxCategory_Name As String
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As String
#End Region

#Region " Box Category Function "
        Public Function GetBoxCategory(ByRef ds As DataSet, Optional ByVal pBoxCategory_ID As String = "") As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                If Len(pBoxCategory_ID) > 0 Then
                    SQLStr = "SELECT * FROM BoxCategory where BoxCategory_ID = " & Integer.Parse(pBoxCategory_ID)
                Else
                    SQLStr = "SELECT * FROM BoxCategory "
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Function SaveBoxCategory() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "SET DATEFORMAT DMY;INSERT INTO BoxCategory "
            SQLStr = SQLStr & "(BoxCategory_Name,Create_Date,Transact_Date,UserID)"
            SQLStr = SQLStr & " VALUES ('" & mvarBoxCategory_Name & "', GetDate(),GetDate(),"
            SQLStr = SQLStr & mvarUserID & ")"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Sub UpdateBoxCategory(ByVal pBoxCategory_ID As String)
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy; Update BoxCategory set "
            strSQL = strSQL & " Transact_Date=GetDate(),"
            strSQL = strSQL & " BoxCategory_Name= '" & Replace(mvarBoxCategory_Name, "'", "''") & "'"
            strSQL = strSQL & " WHERE BoxCategory_ID = " & pBoxCategory_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                End If
            End With
            ds.Dispose()

        End Sub

        Public Function DeleteBoxCategory() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "DELETE FROM BoxCategory WHERE BoxCategory_ID = " & mvarBoxCategory_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function
#End Region

#Region " Box Category Get n Set Statement "
        Public Property BoxCategory_ID() As Integer
            Get
                Return mvarBoxCategory_ID
            End Get
            Set(ByVal Value As Integer)
                mvarBoxCategory_ID = Value
            End Set
        End Property

        Public Property BoxCategory_Name() As String
            Get
                Return mvarBoxCategory_Name
            End Get
            Set(ByVal Value As String)
                mvarBoxCategory_Name = Value
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

    Public Class DrawingNoBusLogic
#Region " Drawing No Variable "
        Private mvarDrawing_ID As Integer
        Private mvarDrawing_No As String
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As String
#End Region

#Region " Drawing No Function "
        
        Public Function GetDrawingNo(ByRef ds As DataSet, Optional ByVal pDrawing_ID As String = "") As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                If Len(pDrawing_ID) > 0 Then
                    SQLStr = "SELECT * FROM DrawingNo where Drawing_ID = " & Integer.Parse(pDrawing_ID)
                Else
                    SQLStr = "SELECT * FROM DrawingNo "
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetDrawingNo_Type(ByRef ds As DataSet, Optional ByVal pDrawing_ID As String = "") As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                If Len(pDrawing_ID) > 0 Then
                    SQLStr = "SELECT Drawing_ID, Drawing_No+Drawing_Type as Drawing_No FROM DrawingNo where Drawing_ID = " & Integer.Parse(pDrawing_ID)
                Else
                    SQLStr = "SELECT Drawing_ID, Drawing_No+Drawing_Type as Drawing_No FROM DrawingNo "
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function SaveDrawingNo() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "SET DATEFORMAT DMY;INSERT INTO DrawingNo "
            SQLStr = SQLStr & "(Drawing_No,Create_Date,Transact_Date,UserID)"
            SQLStr = SQLStr & " VALUES ('" & mvarDrawing_No & "', GetDate(),GetDate(),"
            SQLStr = SQLStr & mvarUserID & ")"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Sub UpdateDrawingNo(ByVal pDrawing_ID As String)
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy; Update BoxCategory set "
            strSQL = strSQL & " Transact_Date=GetDate(),"
            strSQL = strSQL & " Drawing_No= '" & Replace(mvarDrawing_No, "'", "''") & "'"
            strSQL = strSQL & " WHERE Drawing_ID = " & pDrawing_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                End If
            End With
            ds.Dispose()

        End Sub

        Public Function DeleteDrawingNo() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "DELETE FROM BoxCategory WHERE Drawing_ID = " & mvarDrawing_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function
#End Region

#Region " Drawing No Get n Set Statement "
        Public Property Drawing_ID() As Integer
            Get
                Return mvarDrawing_ID
            End Get
            Set(ByVal Value As Integer)
                mvarDrawing_ID = Value
            End Set
        End Property

        Public Property Drawing_No() As String
            Get
                Return mvarDrawing_No
            End Get
            Set(ByVal Value As String)
                mvarDrawing_No = Value
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

    Public Class Department
#Region " Department Variable "
        Private mvarDepartment_ID As Integer
        Private mvarDepartment_Name As String
        Private mvarDepartment_Desc As String
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As String
#End Region
#Region " Department Function "
        Public Function GetDepartment(ByRef ds As DataSet, Optional ByVal pDept_ID As Integer = 0) As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                If pDept_ID > 0 Then
                    SQLStr = "SELECT * FROM Department where Department_ID = " & Integer.Parse(pDept_ID)
                Else
                    SQLStr = "SELECT * FROM Department "
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function SaveDepartment() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "SET DATEFORMAT DMY;INSERT INTO Department "
            SQLStr = SQLStr & "(Name, Description,Create_Date,Transact_Date,UserID)"
            SQLStr = SQLStr & " VALUES ('" & mvarDepartment_Name & "', '" & mvarDepartment_Desc & "', GetDate(),GetDate(),"
            SQLStr = SQLStr & mvarUserID & ")"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Sub UpdateDepartment(ByVal pDepartment_ID As Integer)
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy; Update Department set "
            strSQL = strSQL & " Transact_Date=GetDate(),"
            strSQL = strSQL & " Name= '" & Replace(mvarDepartment_Name, "'", "''") & "'"
            strSQL = strSQL & " Description= '" & Replace(mvarDepartment_Desc, "'", "''") & "'"
            strSQL = strSQL & " WHERE Department_ID = " & pDepartment_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                End If
            End With
            ds.Dispose()

        End Sub

        Public Function DeleteDepartment() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "DELETE FROM Department WHERE Department_ID = " & mvarDepartment_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function
#End Region
#Region " Department ID Get n Set Statement "
        Public Property Department_ID() As Integer
            Get
                Return mvarDepartment_ID
            End Get
            Set(ByVal Value As Integer)
                mvarDepartment_ID = Value
            End Set
        End Property

        Public Property Department_Name() As String
            Get
                Return mvarDepartment_Name
            End Get
            Set(ByVal Value As String)
                mvarDepartment_Name = Value
            End Set
        End Property

        Public Property Department_Desc() As String
            Get
                Return mvarDepartment_Desc
            End Get
            Set(ByVal Value As String)
                mvarDepartment_Desc = Value
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

    Public Class SpecialBusLogic
#Region " SpecialFormat Variable "
        Private mvarSpecial_ID As Integer
        Private mvarSpecial_Name As String
        Private mvarSection1 As String
        Private mvarSection2 As String
        Private mvarSection3 As String
        Private mvarSection4 As String
        Private mvarSection5 As String
        Private mvarSection6 As String
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As String
#End Region

#Region " Special Format Function "
        Public Function GetSpecialFormat(ByRef ds As DataSet, Optional ByVal pSpecial_ID As String = "") As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                If Len(pSpecial_ID) > 0 Then
                    SQLStr = "SELECT * FROM SpecialFormat where Special_ID = " & Integer.Parse(pSpecial_ID)
                Else
                    SQLStr = "SELECT * FROM SpecialFormat "
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Sub UpdateSpecialFormat(ByVal pSpecial_ID As String)
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy; Update SpecialFormat set "
            strSQL = strSQL & " Transact_Date=GetDate(), UserID = " & mvarUserID & ","

            If Len(mvarSection1) > 0 Then
                strSQL = strSQL & " Section1= '" & Replace(mvarSection1, "'", "''") & "',"
            Else
                strSQL = strSQL & " Section1 = NULL, "
            End If

            If Len(mvarSection2) > 0 Then
                strSQL = strSQL & " Section2= '" & Replace(mvarSection2, "'", "''") & "',"
            Else
                strSQL = strSQL & " Section2 = NULL, "
            End If

            If Len(mvarSection3) > 0 Then
                strSQL = strSQL & " Section3= '" & Replace(mvarSection3, "'", "''") & "',"
            Else
                strSQL = strSQL & " Section3 = NULL, "
            End If

            If Len(mvarSection4) > 0 Then
                strSQL = strSQL & " Section4= '" & Replace(mvarSection4, "'", "''") & "',"
            Else
                strSQL = strSQL & " Section4 = NULL, "
            End If

            If Len(mvarSection5) > 0 Then
                strSQL = strSQL & " Section5= '" & Replace(mvarSection5, "'", "''") & "',"
            Else
                strSQL = strSQL & " Section5 = NULL, "
            End If

            If Len(mvarSection6) > 0 Then
                strSQL = strSQL & " Section6= '" & Replace(mvarSection6, "'", "''") & "' "
            Else
                strSQL = strSQL & " Section6 = NULL "
            End If

            strSQL = strSQL & " WHERE Special_ID = " & pSpecial_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                End If
            End With
            ds.Dispose()
        End Sub
#End Region

#Region " Special Format Get n Set Statement "
        Public Property Special_ID() As Integer
            Get
                Return mvarSpecial_ID
            End Get
            Set(ByVal Value As Integer)
                mvarSpecial_ID = Value
            End Set
        End Property

        Public Property Special_Name() As String
            Get
                Return mvarSpecial_Name
            End Get
            Set(ByVal Value As String)
                mvarSpecial_Name = Value
            End Set
        End Property

        Public Property Section1() As String
            Get
                Return mvarSection1
            End Get
            Set(ByVal Value As String)
                mvarSection1 = Value
            End Set
        End Property

        Public Property Section2() As String
            Get
                Return mvarSection2
            End Get
            Set(ByVal Value As String)
                mvarSection2 = Value
            End Set
        End Property

        Public Property Section3() As String
            Get
                Return mvarSection3
            End Get
            Set(ByVal Value As String)
                mvarSection3 = Value
            End Set
        End Property

        Public Property Section4() As String
            Get
                Return mvarSection4
            End Get
            Set(ByVal Value As String)
                mvarSection4 = Value
            End Set
        End Property

        Public Property Section5() As String
            Get
                Return mvarSection5
            End Get
            Set(ByVal Value As String)
                mvarSection5 = Value
            End Set
        End Property

        Public Property Section6() As String
            Get
                Return mvarSection6
            End Get
            Set(ByVal Value As String)
                mvarSection6 = Value
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

    Public Class OfficerInChargeBusLogic
#Region " OfficerInCharge Variable "
        Private mvarOfficer_In_Charge_ID As Integer
        Private mvarOfficer_Name As String
        Private mvarAccount_No As String
        Private mvarTel As String
        Private mvarOfficer_Section As Integer
        Private mvarOfficer_Location As String
        Private mvarTitle As String
        Private mvarSex As String
        Private mvarHandphone1 As String
        Private mvarHandphone2 As String
        Private mvarE_Mail As String
        Private mvarActive_Flg As String
        Private mvarPosition As String
        Private mvarRemarks As String
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As String
#End Region

#Region " OfficerInCharge Function "
        Public Function GetOfficerInChargeHeader(ByRef ds As DataSet, Optional ByVal pOfficer_In_Charge_ID As String = "") As Boolean

            Dim SQLStr As String
            If Len(pOfficer_In_Charge_ID) > 0 Then
                SQLStr = "SELECT * FROM OfficerInCharge where Officer_In_Charge_ID = " & Integer.Parse(pOfficer_In_Charge_ID)
            Else
                SQLStr = "SELECT * FROM OfficerInCharge "
            End If

            SQLStr = SQLStr & " Order by Officer_Name"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetOfficerInCharge(ByRef ds As DataSet, Optional ByVal pOfficer_In_Charge_ID As String = "") As Boolean
            Dim SQLStr As String

            If Len(pOfficer_In_Charge_ID) > 0 Then
                SQLStr = "SELECT * FROM OfficerInCharge where Officer_In_Charge_ID = " & Integer.Parse(pOfficer_In_Charge_ID)
            Else
                SQLStr = "SELECT * FROM OfficerInCharge "
            End If

            SQLStr = SQLStr & " Order by Officer_Name"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                Else
                    Return False
                End If
            End With
        End Function

        Public Function GetOfficerSection(ByRef ds As DataSet, Optional ByVal pSection_ID As String = "") As Boolean
            Dim SQLStr As String

            SQLStr = "SELECT * FROM Section "

            If Len(pSection_ID) > 0 Then
                SQLStr = SQLStr & "WHERE Section_ID =" & pSection_ID
            End If

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function LoadList(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "SELECT * FROM OfficerInCharge"
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function Load(Optional ByVal pOfficer_In_Charge_ID As String = "") As Boolean
            With New DataAccess.DAccess.Access
                Dim ds As DataSet
                Dim SQLStr As String = "SELECT * FROM OfficerInCharge"

                If pOfficer_In_Charge_ID <> "" Then
                    SQLStr = SQLStr & " WHERE Officer_In_Charge_ID =" & pOfficer_In_Charge_ID
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Dim row As DataRow = ds.Tables(0).Rows(0)

                    If Not row.IsNull("Officer_Name") Then
                        Officer_Name = row("Consultant_Name").ToString()
                    Else
                        Officer_Name = ""
                    End If

                    'If Not row.IsNull("Account_No") Then
                    'Account_No = row("Account_No").ToString()
                    'Else
                    'Account_No = ""
                    'End If

                    'If Not row.IsNull("Officer_Section") Then
                    '   Officer_Section = row("Officer_Section").ToString()
                    'Else
                    '   Officer_Section = ""
                    'End If

                    'If Not row.IsNull("Officer_Location") Then
                    '    Officer_Location = row("Country").ToString()
                    'Else
                    '   Officer_Location = ""
                    'End If

                    'If Not row.IsNull("Tel") Then
                    '    Tel = row("Tel").ToString()
                    'Else
                    '    Tel = ""
                    'End If

                    If Not row.IsNull("Title") Then
                        Title = row("Title").ToString()
                    Else
                        Title = ""
                    End If

                    'If Not row.IsNull("Sex") Then
                    '    Sex = row("Sex").ToString()
                    'Else
                    ' Sex = ""
                    'End If

                    'If Not row.IsNull("Handphone1") Then
                    '   Handphone1 = row("Handphone1").ToString()
                    'Else
                    '       Handphone1 = ""
                    'End If

                    'If Not row.IsNull("Handphone2") Then
                    '    Handphone2 = row("Handphone2").ToString()
                    'Else
                    '   Handphone2 = ""
                    'End If

                    'If Not row.IsNull("E_Mail") Then
                    '   E_Mail = row("E_Mail").ToString()
                    'Else
                    '   E_Mail = ""
                    'End If

                    'If Not row.IsNull("Active_Flg") Then
                    '   Active_Flg = row("Active_Flg").ToString()
                    'Else
                    '   Active_Flg = ""
                    'End If

                    'If Not row.IsNull("Position") Then
                    '   Position = row("Position").ToString()
                    'Else
                    '   Position = ""
                    'End If

                    'If Not row.IsNull("Remarks") Then
                    '   Remarks = row("Remarks").ToString()
                    'Else
                    '   Remarks = ""
                    'End If

                    If Not row.IsNull("Create_Date") Then
                        Create_Date = row("Create_Date").ToString()
                    Else
                        Create_Date = ""
                    End If

                    If Not row.IsNull("Transact_Date") Then
                        Transact_Date = row("Transact_Date").ToString()
                    Else
                        Transact_Date = ""
                    End If

                    If Not row.IsNull("UserID") Then
                        UserID = Integer.Parse(row("UserID").ToString())
                    Else
                        UserID = Nothing
                    End If

                    Return True
                End If
            End With
        End Function

        Public Function SaveOfficerInCharge() As Boolean
            Dim dsOfficerInCharge As DataSet

            Dim SQLstr As String = "SET DATEFORMAT dmy;INSERT INTO OfficerInCharge (Officer_Name"
            SQLstr = SQLstr & ", Account_No, Tel"
            SQLstr = SQLstr & ", Section_ID, Contact_Location"
            SQLstr = SQLstr & ", Title, Sex, Handphone1, Handphone2, E_mail"
            SQLstr = SQLstr & ", Active_flg, position, remarks"
            SQLstr = SQLstr & ", Create_Date,Transact_Date,UserID) VALUES "
            SQLstr = SQLstr & "('" & mvarOfficer_Name & "', '" & mvarAccount_No & "', "
            SQLstr = SQLstr & "'" & mvarTel & "', " & mvarOfficer_Section & ","
            SQLstr = SQLstr & "'" & mvarOfficer_Location & "',"
            SQLstr = SQLstr & "'" & mvarTitle & "',"
            SQLstr = SQLstr & "'" & mvarSex & "',"
            SQLstr = SQLstr & "'" & mvarHandphone1 & "',"
            SQLstr = SQLstr & "'" & mvarHandphone2 & "',"
            SQLstr = SQLstr & "'" & mvarE_Mail & "',"
            SQLstr = SQLstr & "'" & mvarActive_Flg & "',"
            SQLstr = SQLstr & "'" & mvarPosition & "',"
            SQLstr = SQLstr & "'" & mvarRemarks & "',"
            SQLstr = SQLstr & "GetDate(),GetDate(),"
            SQLstr = SQLstr & "'" & mvarUserID & "')"

            With New DataAccess.DAccess.Access
                If .GetDataSet(dsOfficerInCharge, SQLstr) Then
                    Return True
                End If
            End With
            dsOfficerInCharge.Dispose()
        End Function

        Public Function UpdateOfficerInCharge(ByVal pOfficer_In_Charge_ID As String) As Boolean
            Dim dsOfficerInCharge As DataSet

            Dim SQLStr As String = "SET DATEFORMAT dmy;UPDATE OfficerInCharge SET "
            SQLStr = SQLStr & " Officer_Name = '" & mvarOfficer_Name & "',"
            SQLStr = SQLStr & " Account_No = '" & mvarAccount_No & "',"
            SQLStr = SQLStr & " Tel = '" & mvarTel & "',"
            SQLStr = SQLStr & " Section_ID = " & mvarOfficer_Section & ","
            SQLStr = SQLStr & " Contact_Location = '" & mvarOfficer_Location & "',"
            SQLStr = SQLStr & " Title = '" & mvarTitle & "',"
            SQLStr = SQLStr & " Sex = '" & mvarSex & "',"
            SQLStr = SQLStr & " Handphone1 = '" & mvarHandphone1 & "',"
            SQLStr = SQLStr & " Handphone2 = '" & mvarHandphone2 & "',"
            SQLStr = SQLStr & " E_Mail = '" & mvarE_Mail & "',"
            SQLStr = SQLStr & " Active_Flg = '" & mvarActive_Flg & "',"
            SQLStr = SQLStr & " Position = '" & mvarPosition & "',"
            SQLStr = SQLStr & " Remarks = '" & mvarRemarks & "',"
            SQLStr = SQLStr & " Transact_Date = GetDate(), "
            SQLStr = SQLStr & " UserID = '" & mvarUserID & "' WHERE "
            SQLStr = SQLStr & " Officer_In_Charge_ID = " & pOfficer_In_Charge_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(dsOfficerInCharge, SQLStr) Then
                    Return True
                End If
            End With
            dsOfficerInCharge.Dispose()
        End Function

#End Region

#Region " DELETE Officer In Charge "
        Public Function DeleteOfficerInCharge(ByVal pOfficer_In_Charge_ID As String) As Boolean
            Dim ds As DataSet
            With New DataAccess.DAccess.Access
                Dim SQLStr As String = "DELETE FROM OfficerInCharge WHERE Officer_In_Charge_ID = " & pOfficer_In_Charge_ID

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function
#End Region

#Region "Validation"
        Public Function RecordExists(ByVal pOfficer_Name As String, Optional ByVal pOfficer_In_Charge_ID As Integer = Nothing) As Boolean

            Dim ds As DataSet
            Dim SQLStr As String
            SQLStr = "SELECT Officer_In_Charge_ID FROM OfficerInCharge"
            SQLStr = SQLStr & " WHERE Officer_Name='" & pOfficer_Name & "'"

            If pOfficer_In_Charge_ID <> Nothing And pOfficer_In_Charge_ID <> 0 Then
                SQLStr = SQLStr & " AND Officer_In_Charge_ID<>" & pOfficer_In_Charge_ID
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

#Region " OfficerInCharge Get n Set Statement "
        Public Property Officer_In_Charge_ID() As Integer
            Get
                Return mvarOfficer_In_Charge_ID
            End Get
            Set(ByVal Value As Integer)
                mvarOfficer_In_Charge_ID = Value
            End Set
        End Property

        Public Property Officer_Name() As String
            Get
                Return mvarOfficer_Name
            End Get
            Set(ByVal Value As String)
                mvarOfficer_Name = Value
            End Set
        End Property

        Public Property Tel() As String
            Get
                Return mvarTel
            End Get
            Set(ByVal Value As String)
                mvarTel = Value
            End Set
        End Property

        Public Property Account_No() As String
            Get
                Return mvarAccount_No
            End Get
            Set(ByVal Value As String)
                mvarAccount_No = Value
            End Set
        End Property

        Public Property Officer_Section() As Integer
            Get
                Return mvarOfficer_Section
            End Get
            Set(ByVal Value As Integer)
                mvarOfficer_Section = Value
            End Set
        End Property

        Public Property Officer_Location() As String
            Get
                Return mvarOfficer_Location
            End Get
            Set(ByVal Value As String)
                mvarOfficer_Location = Value
            End Set
        End Property

        Public Property Title() As String
            Get
                Return mvarTitle
            End Get
            Set(ByVal Value As String)
                mvarTitle = Value
            End Set
        End Property

        Public Property Sex() As String
            Get
                Return mvarSex
            End Get
            Set(ByVal Value As String)
                mvarSex = Value
            End Set
        End Property

        Public Property Handphone1() As String
            Get
                Return mvarHandphone1
            End Get
            Set(ByVal Value As String)
                mvarHandphone1 = Value
            End Set
        End Property

        Public Property Handphone2() As String
            Get
                Return mvarHandphone2
            End Get
            Set(ByVal Value As String)
                mvarHandphone2 = Value
            End Set
        End Property

        Public Property E_Mail() As String
            Get
                Return mvarE_Mail
            End Get
            Set(ByVal Value As String)
                mvarE_Mail = Value
            End Set
        End Property

        Public Property Active_Flg() As String
            Get
                Return mvarActive_Flg
            End Get
            Set(ByVal Value As String)
                mvarActive_Flg = Value
            End Set
        End Property

        Public Property Position() As String
            Get
                Return mvarPosition
            End Get
            Set(ByVal Value As String)
                mvarPosition = Value
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

#Region " Officer Report "

        Public Function GetOfficerReport(ByRef ds As DataSet)
            Dim SQLStr As String

            'SQLStr = "SELECT OfficerInCharge.*, Section.Section_Code FROM OfficerInCharge, Section " '(select column)
            'SQLStr = SQLStr & "WHERE OfficerInCharge.Section_ID = Section.Section_ID"
            SQLStr = "SELECT o.*, s.Section_Code FROM OfficerInCharge o Left Outer Join Section s"
            SQLStr = SQLStr & " On o.Section_ID = s.Section_ID"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function
#End Region

    End Class
    Public Class MaterialBusLogic
#Region " Material Variable "
        Private mvarMaterial_ID As Integer
        Private mvarMaterial_Name As String
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As String
#End Region

#Region " Material Function "
        Public Function GetMaterial(ByRef ds As DataSet, Optional ByVal pMaterial_ID As String = "") As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                If Len(pMaterial_ID) > 0 Then
					SQLStr = "SELECT * FROM Materials where Material_ID = " & Integer.Parse(pMaterial_ID)
                Else
					SQLStr = "SELECT * FROM Materials "
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Function SaveMaterial() As Boolean
            Dim ds As DataSet
			Dim SQLStr As String = "SET DATEFORMAT DMY;INSERT INTO Materials "
			SQLStr = SQLStr & "(MaterialDesc,Create_Date,Transact_Date,UserID)"
            SQLStr = SQLStr & " VALUES ('" & mvarMaterial_Name & "', GetDate(),GetDate(),"
            SQLStr = SQLStr & mvarUserID & ")"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Sub UpdateMaterial(ByVal pMaterial_ID As String)
            Dim strSQL As String
            Dim ds As DataSet

			strSQL = "Set dateformat dmy; Update Materials set "
            strSQL = strSQL & " Transact_Date=GetDate(),"
			strSQL = strSQL & " MaterialDesc= '" & Replace(mvarMaterial_Name, "'", "''") & "'"
            strSQL = strSQL & " WHERE Material_ID = " & pMaterial_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                End If
            End With
            ds.Dispose()

        End Sub

        Public Function DeleteMaterial() As Boolean
            Dim ds As DataSet
			Dim SQLStr As String = "DELETE FROM Materials WHERE Material_ID = " & mvarMaterial_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function
#End Region

#Region " Material Get n Set Statement "
        Public Property Material_ID() As Integer
            Get
                Return mvarMaterial_ID
            End Get
            Set(ByVal Value As Integer)
                mvarMaterial_ID = Value
            End Set
        End Property

        Public Property Material_Name() As String
            Get
                Return mvarMaterial_Name
            End Get
            Set(ByVal Value As String)
                mvarMaterial_Name = Value
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
    Public Class KeyBusLogic
#Region " Key Variable "
        Private mvarKey_ID As Integer
        Private mvarKey_Name As String
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As String
#End Region

#Region " Key Function "
        Public Function GetKey(ByRef ds As DataSet, Optional ByVal pKey_ID As String = "") As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                If Len(pKey_ID) > 0 Then
                    SQLStr = "SELECT * FROM KeyTypes where Key_ID = " & Integer.Parse(pKey_ID)
                Else
                    SQLStr = "SELECT * FROM KeyTypes "
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function SaveKey() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "SET DATEFORMAT DMY;INSERT INTO KeyTypes "
            SQLStr = SQLStr & "(Key_Name,Create_Date,Transact_Date,UserID)"
            SQLStr = SQLStr & " VALUES ('" & mvarKey_Name & "', GetDate(),GetDate(),"
            SQLStr = SQLStr & mvarUserID & ")"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Sub UpdateKey(ByVal pKey_ID As String)
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy; Update KeyTypes set "
            strSQL = strSQL & " Transact_Date=GetDate(),"
            strSQL = strSQL & " Key_Name= '" & Replace(mvarKey_Name, "'", "''") & "'"
            strSQL = strSQL & " WHERE Key_ID = " & pKey_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                End If
            End With
            ds.Dispose()

        End Sub

        Public Function DeleteKey() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "DELETE FROM KeyTypes WHERE Key_ID = " & mvarKey_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Function IsKeyNameInUsed(ByVal pKey_ID As Integer) As Boolean
            With New DataAccess.DAccess.Access
                Dim ds As DataSet
                Dim SQLStr As String

                SQLStr = "SELECT * FROM QuotationHeader where KeyTypes = " & Integer.Parse(pKey_ID)

                If .GetDataSet(ds, SQLStr) Then
                    If Not ds Is Nothing Then
                        If ds.Tables(0).Rows.Count > 0 Then
                            Return True
                        Else
                            SQLStr = "SELECT * FROM WorkOrderHeader where KeyTypes = " & Integer.Parse(pKey_ID)
                            If .GetDataSet(ds, SQLStr) Then
                                If Not ds Is Nothing Then
                                    If ds.Tables(0).Rows.Count > 0 Then
                                        Return True
                                    Else
                                        Return False
                                    End If
                                Else
                                    Return False
                                End If
                            End If
                        End If
                    Else
                        Return False
                    End If
                End If
                ds.Dispose()
            End With
        End Function
#End Region

#Region " Key Get n Set Statement "
        Public Property Key_ID() As Integer
            Get
                Return mvarKey_ID
            End Get
            Set(ByVal Value As Integer)
                mvarKey_ID = Value
            End Set
        End Property

        Public Property Key_Name() As String
            Get
                Return mvarKey_Name
            End Get
            Set(ByVal Value As String)
                mvarKey_Name = Value
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
    Public Class ColorBusLogic
#Region " Color Variable "
        Private mvarColor_ID As Integer
        Private mvarColor_Name As String
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As String
        Private mvarPriceRate As Double
        Private mvarSpecialPriceRate As Double
#End Region

#Region " Color Function "
        Public Function GetColorPriceRate(ByVal pColor_ID As Long) As Double
            Dim ds As DataSet
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                SQLStr = "SELECT pricerate FROM Color where Color_ID = " & pColor_ID

                If .GetDataSet(ds, SQLStr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        GetColorPriceRate = ds.Tables(0).Rows(0)(0)
                    Else : GetColorPriceRate = 0.0
                    End If
                Else
                    GetColorPriceRate = 0.0
                End If
            End With
            ds.Dispose()
        End Function

        Public Function GetColor(ByRef ds As DataSet, Optional ByVal pColor_ID As String = "") As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                If Len(pColor_ID) > 0 Then
                    SQLStr = "SELECT * FROM Color where Color_ID = " & Integer.Parse(pColor_ID)
                Else
                    SQLStr = "SELECT * FROM Color "
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Function SaveColor() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "SET DATEFORMAT DMY;INSERT INTO Color "
            SQLStr = SQLStr & "(Color_Name,Create_Date,Transact_Date,UserID,PriceRate,SpecialPriceRate)"
            SQLStr = SQLStr & " VALUES ('" & mvarColor_Name & "', GetDate(),GetDate(),"
            SQLStr = SQLStr & mvarUserID & "," & mvarPriceRate & "," & mvarSpecialPriceRate & ")"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Sub UpdateColor(ByVal pColor_ID As String)
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy; Update Color set "
            strSQL = strSQL & " Transact_Date=GetDate(),"
            strSQL = strSQL & " Color_Name= '" & Replace(mvarColor_Name, "'", "''") & "', "
            strSQL = strSQL & " PriceRate= " & mvarPriceRate & ", "
            strSQL = strSQL & " SpecialPriceRate =" & mvarSpecialPriceRate
            strSQL = strSQL & " WHERE Color_ID = " & pColor_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                End If
            End With
            ds.Dispose()

        End Sub

        Public Function DeleteColor() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "DELETE FROM Color WHERE Color_ID = " & mvarColor_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Function IsColorNameInUsed(ByVal pColor_ID As Integer) As Boolean
            With New DataAccess.DAccess.Access
                Dim ds As DataSet
                Dim SQLStr As String

                SQLStr = "SELECT * FROM QuotationHeader where Color = " & Integer.Parse(pColor_ID)

                If .GetDataSet(ds, SQLStr) Then
                    If Not ds Is Nothing Then
                        If ds.Tables(0).Rows.Count > 0 Then
                            Return True
                        Else
                            SQLStr = "SELECT * FROM WorkOrderHeader where Color = " & Integer.Parse(pColor_ID)
                            If .GetDataSet(ds, SQLStr) Then
                                If Not ds Is Nothing Then
                                    If ds.Tables(0).Rows.Count > 0 Then
                                        Return True
                                    Else
                                        Return False
                                    End If
                                Else
                                    Return False
                                End If
                            End If
                        End If
                    Else
                        Return False
                    End If
                End If
                ds.Dispose()
            End With
        End Function
#End Region

#Region " Color Get n Set Statement "
        Public Property Color_ID() As Integer
            Get
                Return mvarColor_ID
            End Get
            Set(ByVal Value As Integer)
                mvarColor_ID = Value
            End Set
        End Property

        Public Property Color_Name() As String
            Get
                Return mvarColor_Name
            End Get
            Set(ByVal Value As String)
                mvarColor_Name = Value
            End Set
        End Property
        Public Property PriceRate() As Double
            Get
                Return mvarPriceRate
            End Get
            Set(ByVal Value As Double)
                mvarPriceRate = Value
            End Set
        End Property
        Public Property SpecialPriceRate() As Double
            Get
                Return mvarSpecialPriceRate
            End Get
            Set(ByVal Value As Double)
                mvarSpecialPriceRate = Value
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
    Public Class BrandBusLogic
#Region " Brand Variable "
        Private mvarBrand_ID As Integer
        Private mvarBrand_Name As String
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As String
#End Region

#Region " Brand Function "
        Public Function GetBrand(ByRef ds As DataSet, Optional ByVal pBrand_ID As String = "") As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                If Len(pBrand_ID) > 0 Then
                    SQLStr = "SELECT * FROM Brand where Brand_ID = " & Integer.Parse(pBrand_ID)
                Else
                    SQLStr = "SELECT * FROM Brand "
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Function SaveBrand() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "SET DATEFORMAT DMY;INSERT INTO Brand "
            SQLStr = SQLStr & "(Brand_Name,Create_Date,Transact_Date,UserID)"
            SQLStr = SQLStr & " VALUES ('" & mvarBrand_Name & "', GetDate(),GetDate(),"
            SQLStr = SQLStr & mvarUserID & ")"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Sub UpdateBrand(ByVal pBrand_ID As String)
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy; Update Brand set "
            strSQL = strSQL & " Transact_Date=GetDate(),"
            strSQL = strSQL & " Brand_Name= '" & Replace(mvarBrand_Name, "'", "''") & "'"
            strSQL = strSQL & " WHERE Brand_ID = " & pBrand_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                End If
            End With
            ds.Dispose()

        End Sub

        Public Function DeleteBrand() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "DELETE FROM Brand WHERE Brand_ID = " & mvarBrand_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Function IsBrandNameInUsed(ByVal pBrand_ID As Integer) As Boolean
            With New DataAccess.DAccess.Access
                Dim ds As DataSet
                Dim SQLStr As String

                SQLStr = "SELECT * FROM QuotationHeader where Brand = " & Integer.Parse(pBrand_ID)

                If .GetDataSet(ds, SQLStr) Then
                    If Not ds Is Nothing Then
                        If ds.Tables(0).Rows.Count > 0 Then
                            Return True
                        Else
                            SQLStr = "SELECT * FROM WorkOrderHeader where Brand = " & Integer.Parse(pBrand_ID)
                            If .GetDataSet(ds, SQLStr) Then
                                If Not ds Is Nothing Then
                                    If ds.Tables(0).Rows.Count > 0 Then
                                        Return True
                                    Else
                                        Return False
                                    End If
                                Else
                                    Return False
                                End If
                            End If
                        End If
                    Else
                        Return False
                    End If
                End If
                ds.Dispose()
            End With
        End Function
#End Region

#Region " Brand Get n Set Statement "
        Public Property Brand_ID() As Integer
            Get
                Return mvarBrand_ID
            End Get
            Set(ByVal Value As Integer)
                mvarBrand_ID = Value
            End Set
        End Property

        Public Property Brand_Name() As String
            Get
                Return mvarBrand_Name
            End Get
            Set(ByVal Value As String)
                mvarBrand_Name = Value
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

#Region " Brand Report "
        Public Function GetBrandReport(ByRef ds As DataSet)
            Dim SQLStr As String

            SQLStr = "SELECT b.*, u.Name as UserName " '(select column)
            SQLStr = SQLStr & " FROM Brand b, UserProfile u " '(define table reference) 
            SQLStr = SQLStr & " where b.User_ID = u.User_ID " '(link Brand user_id to userprofile user_id)

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

#End Region

    End Class
    Public Class CurrencyBusLogic
#Region " Currency Variable "
        Private mvarCurrency_ID As Integer
        Private mvarCurrencyName As String
        Private mvarCurrencySymbol As String
        Private mvarExchangeRate_SGD As Decimal
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As String
#End Region
#Region " Currency Function "
        Public Function GetCurrency(ByRef ds As DataSet, Optional ByVal pCurrency_ID As String = "") As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                If Len(pCurrency_ID) > 0 Then
                    SQLStr = "SELECT * FROM Currency where Currency_ID = " & Integer.Parse(pCurrency_ID)
                Else
                    SQLStr = "SELECT * FROM Currency "
                End If
                SQLStr = SQLStr & " Order by CurrencyName"
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Function GetCurrencySymbol(ByVal pCurrency_ID As String) As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String
                Dim ds As DataSet

                SQLStr = "SELECT * FROM Currency where Currency_ID = " & Integer.Parse(pCurrency_ID)

                If .GetDataSet(ds, SQLStr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        mvarCurrencySymbol = ds.Tables(0).Rows(0)("CurrencySymbol")
                        Return True
                    Else
                        Return False
                    End If
                End If
                ds.Dispose()
            End With
        End Function
        Public Function SaveCurrency() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "SET DATEFORMAT DMY;INSERT INTO Currency "
            SQLStr = SQLStr & "(CurrencyName,CurrencySymbol,ExchangeRate_SGD,Create_Date,Transact_Date,UserID)"
            'remove by alan SQLStr = SQLStr & " VALUES ('" & mvarCurrencyName & "'," & mvarCurrencySymbol & ", GetDate(),GetDate(),"
            SQLStr = SQLStr & " VALUES ('" & mvarCurrencyName & "','" & mvarCurrencySymbol & "', mvarExchangeRate_SGD,GetDate(),GetDate(),"
            SQLStr = SQLStr & mvarUserID & ")"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function
        Public Sub UpdateCurrency(ByVal pCurrency_ID As String)

            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy; Update Currency set "
            strSQL = strSQL & " Transact_Date=GetDate(),"

            '27 Oct
            'strSQL = strSQL & " CurrencyName= '" & Replace(mvarCurrencyName, "'", "''") & "',"
            'strSQL = strSQL & " CurrencySymbol= " & mvarCurrencySymbol
            'strSQL = strSQL & " CurrencySymbol= '" & Replace(mvarCurrencySymbol, "'", "''") & "'"
            'strSQL = strSQL & " WHERE Currency_ID = " & pCurrency_ID

            If Len(mvarCurrencyName) > 0 Then
                strSQL = strSQL & " CurrencyName= '" & Replace(mvarCurrencyName, "'", "''") & "',"
            Else
                strSQL = strSQL & " CurrencyName= NULL,"
            End If

            If Len(mvarCurrencySymbol) > 0 Then
                strSQL = strSQL & " CurrencySymbol= '" & Replace(mvarCurrencySymbol, "'", "''") & "',"
            Else
                strSQL = strSQL & " CurrencySymbol= NULL,"
            End If

            strSQL = strSQL & " ExchangeRate_SGD = " & mvarExchangeRate_SGD

            strSQL = strSQL & " WHERE Currency_ID = " & pCurrency_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                End If
            End With
            ds.Dispose()

        End Sub
        Public Function DeleteCurrency() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "DELETE FROM Currency WHERE Currency_ID = " & mvarCurrency_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function
#End Region
#Region " Currency Get n Set Statement "
        Public Property Currency_ID() As Integer
            Get
                Return mvarCurrency_ID
            End Get
            Set(ByVal Value As Integer)
                mvarCurrency_ID = Value
            End Set
        End Property

        Public Property CurrencyName() As String
            Get
                Return mvarCurrencyName
            End Get
            Set(ByVal Value As String)
                mvarCurrencyName = Value
            End Set
        End Property

        Public Property CurrencySymbol() As String
            Get
                Return mvarCurrencySymbol
            End Get
            Set(ByVal Value As String)
                mvarCurrencySymbol = Value
            End Set
        End Property

        Public Property ExchangeRate_SGD() As Decimal
            Get
                Return mvarExchangeRate_SGD
            End Get
            Set(ByVal Value As Decimal)
                mvarExchangeRate_SGD = Value
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
    Public Class UserGroup
#Region " UserGroup Variable "
        Private mvarUserGroup_ID As Integer
        Private mvarUserGroup_Name As String
        Private mvarUserGroup_Desc As String
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As String
#End Region
#Region " UserGroup Function "
        Public Function GetUserGroup(ByRef ds As DataSet, Optional ByVal pUserGroup_ID As Integer = 0) As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                If pUserGroup_ID > 0 Then
                    SQLStr = "SELECT * FROM UserGroup where Group_ID = " & Integer.Parse(pUserGroup_ID)
                Else
                    SQLStr = "SELECT * FROM UserGroup "
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function SaveUserGroup() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "SET DATEFORMAT DMY;INSERT INTO UserGroup "
            SQLStr = SQLStr & "(Name, Description,Create_Date,Transact_Date,UserID)"
            SQLStr = SQLStr & " VALUES ('" & mvarUserGroup_Name & "', '" & mvarUserGroup_Desc & "', GetDate(),GetDate(),"
            SQLStr = SQLStr & mvarUserID & ")"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Sub UpdateUserGroup(ByVal pUserGroup_ID As Integer)
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy; Update UserGroup set "
            strSQL = strSQL & " Transact_Date=GetDate(),"
            strSQL = strSQL & " Name= '" & Replace(mvarUserGroup_Name, "'", "''") & "'"
            strSQL = strSQL & " Description= '" & Replace(mvarUserGroup_Desc, "'", "''") & "'"
            strSQL = strSQL & " WHERE Group_ID = " & pUserGroup_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                End If
            End With
            ds.Dispose()

        End Sub

        Public Function DeleteUserGroup() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "DELETE FROM UserGroup WHERE Group_ID = " & mvarUserGroup_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function
#End Region
#Region " UserGroup ID Get n Set Statement "
        Public Property UserGroup_ID() As Integer
            Get
                Return mvarUserGroup_ID
            End Get
            Set(ByVal Value As Integer)
                mvarUserGroup_ID = Value
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

        Public Property UserGroup_Desc() As String
            Get
                Return mvarUserGroup_Desc
            End Get
            Set(ByVal Value As String)
                mvarUserGroup_Desc = Value
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
    Public Class PaymentTermsBusLogic
#Region " Payment Variable "
        Private mvarPayDetails_ID As Integer
        Private mvarPayDetails As String
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As String
#End Region

#Region " Payment Details Function "
        Public Function GetPaymentDetails(ByRef ds As DataSet, Optional ByVal pPayDetails_ID As String = "") As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                If Len(pPayDetails_ID) > 0 Then
                    SQLStr = "SELECT * FROM PaymentDetails where PayDetails_ID = " & Integer.Parse(pPayDetails_ID)
                Else
                    SQLStr = "SELECT * FROM PaymentDetails "
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Function SavePaymentDetails() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "SET DATEFORMAT DMY;INSERT INTO PaymentDetails "
            SQLStr = SQLStr & "(PayDetails,Create_Date,Transact_Date,UserID)"
            SQLStr = SQLStr & " VALUES ('" & mvarPayDetails & "', GetDate(),GetDate(),"
            SQLStr = SQLStr & mvarUserID & ")"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Sub UpdatePaymentDetails(ByVal pPayDetails_ID As String)
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy; Update PaymentDetails set "
            strSQL = strSQL & " Transact_Date=GetDate(),"
            strSQL = strSQL & " PayDetails= '" & Replace(mvarPayDetails, "'", "''") & "'"
            strSQL = strSQL & " WHERE PayDetails_ID = " & pPayDetails_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                End If
            End With
            ds.Dispose()

        End Sub

        Public Function DeletePaymentDetails() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "DELETE FROM PaymentDetails WHERE PayDetails_ID = " & mvarPayDetails_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function
#End Region

#Region " Payment Get n Set Statement "
        Public Property PayDetails_ID() As Integer
            Get
                Return mvarPayDetails_ID
            End Get
            Set(ByVal Value As Integer)
                mvarPayDetails_ID = Value
            End Set
        End Property

        Public Property PayDetails() As String
            Get
                Return mvarPayDetails
            End Get
            Set(ByVal Value As String)
                mvarPayDetails = Value
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
    Public Class DeliveryTermsBusLogic
#Region " Delivery Variable "
        Private mvarDelTerms_ID As Integer
        Private mvarDeliveryTerms As String
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As String
#End Region

#Region " Delivery Terms Function "
        Public Function GetDeliveryTerms(ByRef ds As DataSet, Optional ByVal pDelTerms_ID As String = "") As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                If Len(pDelTerms_ID) > 0 Then
                    SQLStr = "SELECT * FROM DeliveryTerms where DelTerms_ID = " & Integer.Parse(pDelTerms_ID)
                Else
                    SQLStr = "SELECT * FROM DeliveryTerms "
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Function SaveDeliveryTerms() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "SET DATEFORMAT DMY;INSERT INTO DeliveryTerms "
            SQLStr = SQLStr & "(DeliveryTerms,Create_Date,Transact_Date,UserID)"
            SQLStr = SQLStr & " VALUES ('" & mvarDeliveryTerms & "', GetDate(),GetDate(),"
            SQLStr = SQLStr & mvarUserID & ")"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Sub UpdateDeliveryTerms(ByVal pDelTerms_ID As String)
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy; Update DeliveryTerms set "
            strSQL = strSQL & " Transact_Date=GetDate(),"
            strSQL = strSQL & " DeliveryTerms= '" & Replace(mvarDeliveryTerms, "'", "''") & "'"
            strSQL = strSQL & " WHERE DelTerms_ID = " & pDelTerms_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                End If
            End With
            ds.Dispose()

        End Sub

        Public Function DeleteDeliveryTerms() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "DELETE FROM DeliveryTerms WHERE DelTerms_ID = " & mvarDelTerms_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function
#End Region

#Region " Delivery Terms Get n Set Statement "
        Public Property DelTerms_ID() As Integer
            Get
                Return mvarDelTerms_ID
            End Get
            Set(ByVal Value As Integer)
                mvarDelTerms_ID = Value
            End Set
        End Property

        Public Property DeliveryTerms() As String
            Get
                Return mvarDeliveryTerms
            End Get
            Set(ByVal Value As String)
                mvarDeliveryTerms = Value
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

    Public Class PartCodeBusLogic
#Region " Part Code Variable "
        Private mvarPartCode_ID As Integer
        Private mvarPartCode_Name As String
        Private mvarPartCode_Desc As String
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As String
#End Region

#Region " Part Code Function "

        Public Function GetPartCode(ByRef ds As DataSet, Optional ByVal pPartCode_ID As String = "") As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                If Len(pPartCode_ID) > 0 Then
                    SQLStr = "SELECT * FROM PartCode where PartCode_ID = " & Integer.Parse(pPartCode_ID) & " order by partcodename"
                Else
                    SQLStr = "SELECT * FROM PartCode order by partcodename"
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function SavePartCode() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "SET DATEFORMAT DMY;INSERT INTO PartCode "
            SQLStr = SQLStr & "(PartCodeName,PartCodeDesc, Create_Date, Transact_Date, UserID)"
            SQLStr = SQLStr & " VALUES ('" & mvarPartCode_Name & "', '" & mvarPartCode_Desc & "', GetDate(), GetDate(), " & mvarUserID & ")"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Sub UpdatePartCode(ByVal pPartCode_ID As String)
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy; Update PartCode set "
            strSQL = strSQL & " PartCodeName='" & mvarPartCode_Name & "', "
            strSQL = strSQL & " PartCodeDesc='" & Replace(mvarPartCode_Desc, "'", "''") & "',"
            strSQL = strSQL & " Transact_Date=GetDate()"
            If mvarUserID.Length > 0 Then
                strSQL = strSQL & ", UserID = " & mvarUserID
            End If
            strSQL = strSQL & " WHERE PartCode_ID = " & pPartCode_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                End If
            End With
            ds.Dispose()

        End Sub

        Public Function DeletePartCode() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "DELETE FROM PartCode WHERE PartCode_ID = " & mvarPartCode_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function
#End Region

#Region " Part Code Get n Set Statement "
        Public Property PartCode_ID() As Integer
            Get
                Return mvarPartCode_ID
            End Get
            Set(ByVal Value As Integer)
                mvarPartCode_ID = Value
            End Set
        End Property

        Public Property PartCode_Name() As String
            Get
                Return mvarPartCode_Name
            End Get
            Set(ByVal Value As String)
                mvarPartCode_Name = Value
            End Set
        End Property

        Public Property PartCode_Desc() As String
            Get
                Return mvarPartCode_Desc
            End Get
            Set(ByVal Value As String)
                mvarPartCode_Desc = Value
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

    Public Class MaterialsBusLogic
#Region " Materials Variable "
        Private mvarMaterial_ID As Integer
        Private mvarMaterial_Code As String
        Private mvarMaterial_Desc As String
#End Region

#Region " Materials Function "
        Public Function GetMaterial(ByRef ds As DataSet, Optional ByVal pMaterial_ID As String = "") As Boolean
            With New DataAccess.DAccess.Access
                Dim SQLStr As String

                If Len(pMaterial_ID) > 0 Then
                    SQLStr = "SELECT * FROM Materials where Material_ID = " & Integer.Parse(pMaterial_ID)
                Else
                    SQLStr = "SELECT * FROM Materials "
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Function SaveMaterial() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "SET DATEFORMAT DMY;INSERT INTO Materials "
            SQLStr = SQLStr & "(MaterialCode,MaterialDesc)"
            SQLStr = SQLStr & " VALUES ('" & mvarMaterial_Code & "', '" & mvarMaterial_Desc & "')"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Sub UpdateMaterial(ByVal pMaterial_ID As String)
            Dim strSQL As String
            Dim ds As DataSet

            strSQL = "Set dateformat dmy; Update Materials set "
            strSQL = strSQL & " MaterialCode='" & mvarMaterial_Code & ","
            strSQL = strSQL & " MaterialDesc='" & Replace(mvarMaterial_Desc, "'", "''") & "'"
            strSQL = strSQL & " WHERE Material_ID = " & pMaterial_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, strSQL) Then
                End If
            End With
            ds.Dispose()

        End Sub

        Public Function DeleteMaterial() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "DELETE FROM Materials WHERE Material_ID = " & mvarMaterial_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function
#End Region

#Region " Material Get n Set Statement "
        Public Property Material_ID() As Integer
            Get
                Return mvarMaterial_ID
            End Get
            Set(ByVal Value As Integer)
                mvarMaterial_ID = Value
            End Set
        End Property

        Public Property Material_Code() As String
            Get
                Return mvarMaterial_Code
            End Get
            Set(ByVal Value As String)
                mvarMaterial_Code = Value
            End Set
        End Property

        Public Property Material_Desc() As String
            Get
                Return mvarMaterial_Desc
            End Get
            Set(ByVal Value As String)
                mvarMaterial_Desc = Value
            End Set
        End Property
#End Region
    End Class

    Public Class ApprovalBusLogic



    End Class

End Namespace
