Imports DevExpress.XtraEditors.Controls
Imports System.Drawing

Namespace CommonBusRules
    Public Class CommonLogic
        Private mvarUserID As String

        Public Sub SetComboValue(ByVal data As String(), ByVal comboBox As DevExpress.XtraEditors.LookUpEdit, ByVal id As String())
            Dim i
            Dim j
            Dim records(data.Length - 1) As Record
            records(0) = New Record("", "")

            If Not id Is Nothing Then
                For i = 0 To data.Length - 1
                    records(i) = New Record(data(i), id(i))
                Next
            Else
                For i = 0 To data.Length - 1
                    j = i - 1
                    records(i) = New Record(data(i), j.ToString)
                Next
            End If

            comboBox.Properties.LookUpData.ListFields.Clear()

            AddListFieldInfoToLookUp(comboBox, "Name", 200, 0, "")
            comboBox.Properties.LookUpData.KeyField = "ID"
            comboBox.Properties.LookUpData.DisplayField = "Name"

            comboBox.Properties.LookUpData.DataSource = records
        End Sub
        Public Sub AddListFieldInfoToLookUp(ByVal le As DevExpress.XtraEditors.LookUpEdit, ByVal field As String, ByVal width As Integer, ByVal alignment As Object, ByVal format As String)
            Dim luColumnInfo = New LookUpColumnInfo(field, width)
            If format = "c" Then
                luColumnInfo.FormatType = LookUpFormatType.Numeric
                luColumnInfo.FormatString = format
            End If
            luColumnInfo.Alignment = CType(alignment, StringAlignment)
            le.Properties.LookUpData.ListFields.Add(luColumnInfo)
        End Sub

        Public Sub AddListFieldInfoToLookUp(ByVal le As DevExpress.XtraEditors.LookUpEdit, ByVal field As String, ByVal caption As String, ByVal width As Integer, ByVal alignment As Object, ByVal format As String)
            Dim luColumnInfo = New LookUpColumnInfo(field, width, caption)
            If format = "c" Then
                luColumnInfo.FormatType = LookUpFormatType.Numeric
                luColumnInfo.FormatString = format
            End If
            luColumnInfo.Alignment = CType(alignment, StringAlignment)
            le.Properties.LookUpData.ListFields.Add(luColumnInfo)
        End Sub

        Public Sub AddListFieldInfoToRepositoryLookUp(ByVal le As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit, ByVal field As String, ByVal width As Integer, ByVal alignment As Object, ByVal format As String)
            Dim luColumnInfo = New LookUpColumnInfo(field, width)
            If format = "c" Then
                luColumnInfo.FormatType = LookUpFormatType.Numeric
                luColumnInfo.FormatString = format
            End If
            luColumnInfo.Alignment = CType(alignment, StringAlignment)
            le.Properties.LookUpData.ListFields.Add(luColumnInfo)
        End Sub

        Public Function GetDocumentNextNumber(ByVal pDocumentCode As String) As String
            Dim ds As DataSet
            Dim NextNumber As Integer
            Dim DocNo As String
            Dim YearStr As String
            Dim Digits As Integer

            Dim SQLstr As String = "SELECT * FROM DocumentNumber WHERE DocumentCode = '" & pDocumentCode & "'"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLstr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        'GetDocumentNextNumber = ds.Tables(0).Rows(0)("DocumentNextNumber")
                        NextNumber = ds.Tables(0).Rows(0)("DocumentNextNumber")
                        Digits = ds.Tables(0).Rows(0)("Digits")
                        DocNo = NextNumber.ToString
                        DocNo = DocNo.PadLeft(Digits, "0")

                        'If ds.Tables(0).Rows(0)("PadYear") = 1 Then
                        'YearStr = Year(Today()).ToString
                        'YearStr = YearStr.Substring(YearStr.Length - 1, 1)
                        'DocNo = YearStr & DocNo
                        'End If

                        If IsDBNull(ds.Tables(0).Rows(0)("Prefix")) = False Then
                            DocNo = ds.Tables(0).Rows(0)("Prefix") & DocNo
                        End If

                        If IsDBNull(ds.Tables(0).Rows(0)("Postfix")) = False Then
                            DocNo = DocNo & ds.Tables(0).Rows(0)("Postfix")
                        End If

                        GetDocumentNextNumber = DocNo

                        NextNumber = NextNumber + ds.Tables(0).Rows(0)("IncrementValue")
                        Me.UpdateDocumentNextNumber(NextNumber, pDocumentCode)
                    End If
                End If
            End With
            ds.Dispose()
        End Function

        Public Function GetDocumentNextNumber(ByVal pDocumentCode As String, ByVal pYearVal As Integer, ByVal Update As Boolean, Optional ByVal pPrefix As String = "") As String
            Dim ds As DataSet
            Dim ds2 As DataSet
            Dim NextNumber As Integer
            Dim PadYear As Integer
            Dim DocNo As String
            Dim YearStr As String
            Dim Digits As Integer

            Dim SQLstr As String = "SELECT * FROM DocumentNumber WHERE DocumentCode = '" & pDocumentCode & "'"
            SQLstr = SQLstr & " and YearVal=" & pYearVal

            'Insert if not found
            With New DataAccess.DAccess.Access
                If .GetDataSet(ds2, SQLstr) Then
                    If ds2.Tables(0).Rows.Count = 0 Then
                        Dim SQLstr2 As String = "Insert into DocumentNumber (Prefix, PadYear,Digits,DocumentCode,DocumentNextNumber,IncrementValue,YearVal,Create_Date,Transact_Date) "
                        SQLstr2 = SQLstr2 & "values ('" & pPrefix & "', 0,4,'" & pDocumentCode & "',1,1," & pYearVal & ",getdate(),getdate())"
                        .ExecuteQuery(SQLstr2)
                    End If
                End If
            End With

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLstr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        'GetDocumentNextNumber = ds.Tables(0).Rows(0)("DocumentNextNumber")
                        NextNumber = ds.Tables(0).Rows(0)("DocumentNextNumber")
                        Digits = ds.Tables(0).Rows(0)("Digits")
                        DocNo = NextNumber.ToString
                        DocNo = DocNo.PadLeft(Digits, "0")
                        PadYear = Convert.ToInt32(ds.Tables(0).Rows(0)("PadYear"))
                        If PadYear >= 1 Then
                            YearStr = Year(Today()).ToString
                            YearStr = YearStr.Substring(YearStr.Length - PadYear, PadYear)
                            DocNo = YearStr & DocNo
                        End If

                        If IsDBNull(ds.Tables(0).Rows(0)("Prefix")) = False Then
                            DocNo = ds.Tables(0).Rows(0)("Prefix") & DocNo
                        End If

                        If IsDBNull(ds.Tables(0).Rows(0)("Postfix")) = False Then
                            DocNo = DocNo & ds.Tables(0).Rows(0)("Postfix")
                        End If

                        GetDocumentNextNumber = DocNo

                        If Update = True Then
                            NextNumber = NextNumber + ds.Tables(0).Rows(0)("IncrementValue")
                            Me.UpdateDocumentNextNumber(NextNumber, pDocumentCode)
                        End If
                    Else

                    End If
                End If
            End With
            ds.Dispose()
        End Function

        Public Function GetDocumentNumber(ByVal pDocumentCode As String, ByVal pYearVal As Integer, ByVal Update As Boolean, ByVal pNewDocNo As Integer, Optional ByVal pPrefix As String = "") As String
            Dim ds As DataSet
            Dim ds2 As DataSet
            Dim NextNumber As Integer
            Dim PadYear As Integer
            Dim DocNo As String
            Dim YearStr As String
            Dim Digits As Integer

            Dim SQLstr As String = "SELECT * FROM DocumentNumber WHERE DocumentCode = '" & pDocumentCode & "'"
            SQLstr = SQLstr & " and YearVal=" & pYearVal

            'Insert if not found
            With New DataAccess.DAccess.Access
                If .GetDataSet(ds2, SQLstr) Then
                    If ds2.Tables(0).Rows.Count = 0 Then
                        Dim SQLstr2 As String = "Insert into DocumentNumber (Prefix, PadYear,Digits,DocumentCode,DocumentNextNumber,IncrementValue,YearVal,Create_Date,Transact_Date) "
                        SQLstr2 = SQLstr2 & "values ('" & pPrefix & "', 0,4,'" & pDocumentCode & "',1,1," & pYearVal & ",getdate(),getdate())"
                        .ExecuteQuery(SQLstr2)
                    End If
                End If
            End With

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLstr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        'GetDocumentNextNumber = ds.Tables(0).Rows(0)("DocumentNextNumber")
                        'NextNumber = ds.Tables(0).Rows(0)("DocumentNextNumber")
                        NextNumber = pNewDocNo

                        Digits = ds.Tables(0).Rows(0)("Digits")
                        DocNo = NextNumber.ToString
                        DocNo = DocNo.PadLeft(Digits, "0")
                        PadYear = Convert.ToInt32(ds.Tables(0).Rows(0)("PadYear"))
                        If PadYear >= 1 Then
                            YearStr = Year(Today()).ToString
                            YearStr = YearStr.Substring(YearStr.Length - PadYear, PadYear)
                            DocNo = YearStr & DocNo
                        End If

                        If IsDBNull(ds.Tables(0).Rows(0)("Prefix")) = False Then
                            DocNo = ds.Tables(0).Rows(0)("Prefix") & DocNo
                        End If

                        If IsDBNull(ds.Tables(0).Rows(0)("Postfix")) = False Then
                            DocNo = DocNo & ds.Tables(0).Rows(0)("Postfix")
                        End If

                        GetDocumentNumber = DocNo

                        If Update = True Then
                            NextNumber = NextNumber + ds.Tables(0).Rows(0)("IncrementValue")
                            Me.UpdateDocumentNextNumber(NextNumber, pDocumentCode)
                        End If
                    Else

                    End If
                End If
            End With
            ds.Dispose()
        End Function

        Public Function GetDocumentNextNumber(ByVal pDocumentCode As String, ByVal Update As Boolean) As String
            Dim ds As DataSet
            Dim NextNumber As Integer
            Dim DocNo As String
            Dim YearStr As String
            Dim Digits As Integer

            Dim SQLstr As String = "SELECT * FROM DocumentNumber WHERE DocumentCode = '" & pDocumentCode & "'"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLstr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        'GetDocumentNextNumber = ds.Tables(0).Rows(0)("DocumentNextNumber")
                        NextNumber = ds.Tables(0).Rows(0)("DocumentNextNumber")
                        Digits = ds.Tables(0).Rows(0)("Digits")
                        DocNo = NextNumber.ToString
                        DocNo = DocNo.PadLeft(Digits, "0")
                        If ds.Tables(0).Rows(0)("PadYear") = 1 Then
                            YearStr = Year(Today()).ToString
                            YearStr = YearStr.Substring(YearStr.Length - 1, 1)
                            DocNo = YearStr & DocNo
                        End If

                        If IsDBNull(ds.Tables(0).Rows(0)("Prefix")) = False Then
                            DocNo = ds.Tables(0).Rows(0)("Prefix") & DocNo
                        End If

                        If IsDBNull(ds.Tables(0).Rows(0)("Postfix")) = False Then
                            DocNo = DocNo & ds.Tables(0).Rows(0)("Postfix")
                        End If

                        GetDocumentNextNumber = DocNo

                        If Update = True Then
                            NextNumber = NextNumber + ds.Tables(0).Rows(0)("IncrementValue")
                            Me.UpdateDocumentNextNumber(NextNumber, pDocumentCode)
                        End If
                    End If
                End If
            End With
            ds.Dispose()
        End Function

       

        Public Sub UpdateDocumentNextNumber(ByVal pDocumentCode As String)
            Dim ds As DataSet
            Dim NextNumber As Integer

            Dim SQLstr As String = "SELECT * FROM DocumentNumber WHERE DocumentCode = '" & pDocumentCode & "'"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLstr) Then
                    NextNumber = ds.Tables(0).Rows(0)("DocumentNextNumber") + ds.Tables(0).Rows(0)("IncrementValue")

                    SQLstr = "UPDATE DocumentNumber SET "
                    SQLstr = SQLstr & "DocumentNextNumber = " & NextNumber & ","
                    SQLstr = SQLstr & "Transact_Date = GetDate(),"
                    SQLstr = SQLstr & "UserID = '" & mvarUserID & "' "
                    SQLstr = SQLstr & " WHERE DocumentCode = '" & pDocumentCode & "'"

                    If .GetDataSet(ds, SQLstr) Then
                    End If
                End If
            End With
            ds.Dispose()
        End Sub

        Public Sub UpdateDocumentNextNumber(ByVal pDocumentCode As String, ByVal pYearVal As Integer)
            Dim ds As DataSet
            Dim NextNumber As Integer

            Dim SQLstr As String = "SELECT * FROM DocumentNumber WHERE DocumentCode = '" & pDocumentCode & "' And YearVal = " & pYearVal

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLstr) Then
                    NextNumber = ds.Tables(0).Rows(0)("DocumentNextNumber") + ds.Tables(0).Rows(0)("IncrementValue")

                    SQLstr = "UPDATE DocumentNumber SET "
                    SQLstr = SQLstr & "DocumentNextNumber = " & NextNumber & ","
                    SQLstr = SQLstr & "Transact_Date = GetDate(),"
                    SQLstr = SQLstr & "UserID = '" & mvarUserID & "' "
                    SQLstr = SQLstr & " WHERE DocumentCode = '" & pDocumentCode & "' And YearVal = " & pYearVal

                    If .GetDataSet(ds, SQLstr) Then
                    End If
                End If
            End With
            ds.Dispose()
        End Sub

        Public Sub UpdateDocumentNextNumber(ByVal pNextNumber As Integer, ByVal pDocumentCode As String)
            Dim ds As DataSet

            Dim SQLstr As String = "UPDATE DocumentNumber SET "
            SQLstr = SQLstr & "DocumentNextNumber = " & pNextNumber & ","
            SQLstr = SQLstr & "Transact_Date = GetDate(),"
            SQLstr = SQLstr & "UserID = '" & mvarUserID & "' "
            SQLstr = SQLstr & " WHERE DocumentCode = '" & pDocumentCode & "'"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLstr) Then
                End If
            End With
            ds.Dispose()
        End Sub

        Public Sub UpdateDocumentNextNumber(ByVal pNextNumber As Integer, ByVal pDocumentCode As String, ByVal pYearVal As Integer)
            Dim ds As DataSet

            Dim SQLstr As String = "UPDATE DocumentNumber SET "
            SQLstr = SQLstr & "DocumentNextNumber = " & pNextNumber & ","
            SQLstr = SQLstr & "Transact_Date = GetDate(),"
            SQLstr = SQLstr & "UserID = '" & mvarUserID & "' "
            SQLstr = SQLstr & " WHERE DocumentCode = '" & pDocumentCode & "' and YearVal=" & pYearVal

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLstr) Then
                End If
            End With
            ds.Dispose()
        End Sub

        Public Property UserID() As String
            Get
                Return mvarUserID
            End Get
            Set(ByVal Value As String)
                mvarUserID = Value
            End Set
        End Property

#Region " Get n Set Statement"
        Private Class Record
            Private mvarName As String
            Private mvarID As String

            Public Sub New(ByVal a As String, ByVal b As String)
                Me.mvarName = a
                Me.mvarID = b
            End Sub

            Public Property Name() As String
                Get
                    Return mvarName
                End Get
                Set(ByVal Value As String)
                    mvarName = Value
                End Set
            End Property

            Public Property ID() As String
                Get
                    Return mvarID
                End Get
                Set(ByVal Value As String)
                    mvarID = Value
                End Set
            End Property


        End Class
#End Region

    End Class

End Namespace
