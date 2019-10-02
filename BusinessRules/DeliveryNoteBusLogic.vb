
Namespace DeliveryNoteBusRules

    Public Class DeliveryNoteBusLogic

#Region "Variables Initialization"
        ' Header
        Private mvarDN_ID As Integer
        Private mvarStatus As String
        Private mvarDN_No As String
        Private mvarWO_ID As Integer
        Private mvarSupplier_ID As Integer
        Private mvarCompletion_Date As String
        Private mvarRemark As String
        Private mvarProcess_Type As String
        Private mvarRevRefDNID As Integer
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As String

        ' Line
        Private mvarDN_Line_ID As Integer
        Private mvarLnDN_ID As Integer
        Private mvarLnPartCode_ID As Integer
        Private mvarLnQty As String
        Private mvarLnCategory_ID As Integer
        Private mvarLnProduct_ID As Integer
        Private mvarLnWIP As String
        Private mvarLnInstruction As String
        Private mvarLnColor_ID As Integer
        Private mvarLnDimension As String
        Private mvarLnCreate_Date As String
        Private mvarLnTransact_Date As String
        Private mvarLnUserID As Integer

#End Region

#Region "Delivery Note Header"

        Public Function GetDNHeader(ByRef ds As DataSet, Optional ByVal pDN_ID As String = "") As Boolean
            Dim SQLStr As String

            If Len(pDN_ID) > 0 Then
                SQLStr = "SET DATEFORMAT dmy;SELECT DN.*,UP.Login_Id FROM DeliveryNoteHeader DN "
                SQLStr = SQLStr & " LEFT JOIN UserProfile UP on (DN.UserId=UP.User_Id)"
                SQLStr = SQLStr & "WHERE DN_ID =" & pDN_ID
            Else
                SQLStr = "SET DATEFORMAT dmy;SELECT DN.*,UP.Login_Id FROM DeliveryNoteHeader DN "
                SQLStr = SQLStr & " LEFT JOIN UserProfile UP on (DN.UserId=UP.User_Id)"
            End If

            SQLStr = SQLStr & " Order by DN_No"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetDeliveryNoteHeader(ByRef ds As DataSet, ByVal pDN_ID As String) As Boolean
            Dim SQLStr As String

            SQLStr = "SET DATEFORMAT dmy;SELECT * FROM DeliveryNoteHeader "
            SQLStr = SQLStr & "WHERE DN_ID =" & pDN_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function LoadList(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "SELECT * FROM DeliveryNoteHeader"
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function Load(Optional ByVal pDN_ID As String = "") As Boolean
            With New DataAccess.DAccess.Access
                Dim ds As DataSet
                Dim SQLStr As String = "SELECT * FROM DeliveryNoteHeader"

                If pDN_ID <> "" Then
                    SQLStr = SQLStr & " WHERE DN_ID =" & pDN_ID
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Dim row As DataRow = ds.Tables(0).Rows(0)

                    If Not row.IsNull("Status") Then
                        Status = row("Status").ToString()
                    Else
                        Status = ""
                    End If

                    If Not row.IsNull("DN_No") Then
                        DN_No = row("DN_No").ToString()
                    Else
                        DN_No = ""
                    End If

                    If Not row.IsNull("WO_ID") Then
                        WO_ID = row("WO_ID").ToString()
                    Else
                        WO_ID = ""
                    End If

                    If Not row.IsNull("Supplier_ID") Then
                        Supplier_ID = Integer.Parse(row("Supplier").ToString())
                    Else
                        Supplier_ID = ""
                    End If

                    If Not row.IsNull("Completion_Date") Then
                        Completion_Date = row("Completion_Date").ToString()
                    Else
                        Completion_Date = ""
                    End If

                    If Not row.IsNull("Remark") Then
                        Remark = row("Remark").ToString()
                    Else
                        Remark = ""
                    End If

                    If Not row.IsNull("Process_Type") Then
                        Process_Type = row("Process_Type").ToString()
                    Else
                        Process_Type = ""
                    End If

                    If Not row.IsNull("RevRefDNID") Then
                        RevRefDNID = row("RevRefNDID").ToString()
                    Else
                        RevRefDNID = ""
                    End If

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

        Public Function SaveDeliveryNoteHeader() As Boolean
            Dim dsDeliveryNoteHeader As DataSet
            Dim SQLstr As String

            SQLstr = "SET DATEFORMAT dmy;INSERT INTO DeliveryNoteHeader (Status"
            SQLstr = SQLstr & ", DN_No, WO_ID, Supplier_ID, Completion_Date"
            SQLstr = SQLstr & ", Remark, Process_Type"
            SQLstr = SQLstr & ", RevRefDNID, Create_Date,Transact_Date,UserID) VALUES "
            SQLstr = SQLstr & "('" & mvarStatus & "','" & mvarDN_No & "', " & mvarWO_ID & ", "
            SQLstr = SQLstr & mvarSupplier_ID & ", '" & mvarCompletion_Date & "',"
            SQLstr = SQLstr & "'" & mvarRemark & "', '" & mvarProcess_Type & "',"
            SQLstr = SQLstr & mvarRevRefDNID & ", Getdate(), GetDate(),"
            SQLstr = SQLstr & "'" & mvarUserID & "')"
            SQLstr = SQLstr & ";SELECT @@identity as DN_ID FROM DeliveryNoteHeader"

            With New DataAccess.DAccess.Access
                If .GetDataSet(dsDeliveryNoteHeader, SQLstr) Then
                    If dsDeliveryNoteHeader.Tables(0).Rows.Count > 0 Then
                        mvarDN_ID = dsDeliveryNoteHeader.Tables(0).Rows(0)(0)
                    End If
                    Return True
                End If
            End With
            dsDeliveryNoteHeader.Dispose()
        End Function

        Public Function UpdateDeliveryNoteHeader(ByVal pDN_ID As String) As Boolean
            Dim dsDeliveryNoteHeader As DataSet
            Dim SQLStr As String

            SQLStr = "SET DATEFORMAT dmy;UPDATE DeliveryNoteHeader SET "
            SQLStr = SQLStr & " Status = '" & mvarStatus & "',"
            SQLStr = SQLStr & " DN_No = '" & mvarDN_No & "',"
            SQLStr = SQLStr & " WO_ID = " & mvarWO_ID & ","
            SQLStr = SQLStr & " Supplier_ID = " & mvarSupplier_ID & ","
            SQLStr = SQLStr & " Completion_Date = '" & mvarCompletion_Date & "',"
            SQLStr = SQLStr & " Remark = '" & mvarRemark & "',"
            SQLStr = SQLStr & " Process_Type = '" & mvarProcess_Type & "',"
            SQLStr = SQLStr & " RevRefDNID = " & mvarRevRefDNID & ","
            SQLStr = SQLStr & " Transact_Date = GetDate(), "
            SQLStr = SQLStr & " UserID = '" & mvarUserID & "' WHERE "
            SQLStr = SQLStr & " DN_ID = " & pDN_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(dsDeliveryNoteHeader, SQLStr) Then
                    Return True
                End If
            End With
            dsDeliveryNoteHeader.Dispose()
        End Function

        Public Function UpdateDeliveryNoteHeaderStatus() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "SET DATEFORMAT dmy;UPDATE DeliveryNoteHeader SET "
            SQLStr = SQLStr & " Status = '" & mvarStatus & "' WHERE DN_ID = " & mvarDN_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
            ds.Dispose()
        End Function

        Public Function IsRevisedDN(ByRef dsSub As DataSet) As Boolean
            Dim ds As DataSet
            Dim SQLstr As String = "SELECT RevRefDNID FROM DeliveryNoteHeader "
            SQLstr = SQLstr & " WHERE DN_ID = " & mvarDN_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLstr) Then
                    If Not IsDBNull(ds.Tables(0).Rows(0)("RevRefDNID")) Then
                        If ds.Tables(0).Rows(0)("RevRefDNID") = 0 Then
                            Return False
                        Else
                            Dim SubSQLStr As String = "SELECT DN_ID, DN_NO FROM DeliveryNoteHeader "
                            SubSQLStr = SubSQLStr & " WHERE DN_ID = " & ds.Tables(0).Rows(0)("RevRefDNID")

                            If .GetDataSet(dsSub, SubSQLStr) Then
                                Return True
                            End If

                        End If
                    Else
                        Return False
                    End If
                End If
            End With
            ds.Dispose()
        End Function

        Public Function CountNoOfRevisedDN() As Integer
            Dim ds As DataSet
            Dim SQLstr As String = "SELECT COUNT(*) FROM DeliveryNoteHeader "
            SQLstr = SQLstr & " WHERE RevRefDNID = " & mvarRevRefDNID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLstr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        CountNoOfRevisedDN = ds.Tables(0).Rows(0)(0) + 1
                    Else
                        CountNoOfRevisedDN = 1
                    End If
                End If
            End With
            ds.Dispose()
        End Function

        Public Function CheckExistingDNNo() As Boolean
            Dim ds As DataSet
            Dim SQLstr As String = "SELECT DN_NO FROM DeliveryNoteHeader "
            SQLstr = SQLstr & " WHERE DN_NO = '" & mvarDN_No & "'"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLstr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        Return True            'return false if quotation exist
                    Else
                        Return False
                    End If
                End If
            End With
        End Function

        'Initial saving. To get the DN_ID
        Public Function SaveDNNo() As Boolean
            Dim dsDN As DataSet
            With New DataAccess.DAccess.Access
                Dim SQLstr As String = "SET DATEFORMAT dmy;INSERT INTO DeliveryNoteHeader "
                SQLstr = SQLstr & "(DN_No, Status, WO_ID , Create_Date,Transact_Date,UserID) "
                SQLstr = SQLstr & " VALUES ('" & mvarStatus & "','" & mvarDN_No & "',"
                SQLstr = SQLstr & "mvarWO_ID, Getdate(), GetDate(),"
                SQLstr = SQLstr & "'" & mvarUserID & "') "
                SQLstr = SQLstr & ";SELECT @@identity as DN_ID FROM DeliveryNoteHeader"

                If .GetDataSet(dsDN, SQLstr) Then
                    If dsDN.Tables(0).Rows.Count > 0 Then
                        mvarDN_ID = dsDN.Tables(0).Rows(0)(0)
                    End If
                    Return True
                End If
                dsDN.Dispose()
            End With
        End Function
#End Region

#Region "Delivery Note Line"
        Public Function GetDNLine_ByLineID(ByRef ds As DataSet, ByVal pDN_Line_ID As String) As Boolean
            Dim SQLStr As String

            SQLStr = "SET DATEFORMAT dmy;SELECT * FROM DeliveryNoteLine "
            SQLStr = SQLStr & "WHERE DN_Line_ID =" & pDN_Line_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetDNLine(ByRef ds As DataSet, Optional ByVal pDN_ID As String = "") As Boolean
            Dim SQLStr As String

            If Len(pDN_ID) > 0 Then
                SQLStr = "SET DATEFORMAT dmy;SELECT * FROM DeliveryNoteLine "
                SQLStr = SQLStr & "WHERE DN_ID =" & pDN_ID
            Else
                SQLStr = "SET DATEFORMAT dmy;SELECT * FROM DeliveryNoteLine"
            End If

            SQLStr = SQLStr & " Order by DN_Line_ID"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetDNLine_Display(ByRef ds As DataSet, Optional ByVal pDN_ID As String = "") As Boolean
            Dim SQLStr As String

            If Len(pDN_ID) > 0 Then
                SQLStr = "SELECT Proj.PartCodeName as PartCodeName, DNLine.*, Color.Color_Name "
                SQLStr = SQLStr & " FROM DeliveryNoteLine DNLine, PartCode Proj, Color "
                SQLStr = SQLStr & "WHERE "
                SQLStr = SQLStr & " DNLine.PartCode_ID = Proj.PartCode_ID and "
                SQLStr = SQLStr & " DNLine.Color_ID = Color.Color_ID and "
                SQLStr = SQLStr & " DNLine.DN_ID = " & pDN_ID
            Else
                SQLStr = "SELECT Proj.PartCodeName as PartCodeName, DNLine.*, Color.Color_Name  "
                SQLStr = SQLStr & " FROM DeliveryNoteLine DNLine, PartCode Proj, Color "
                SQLStr = SQLStr & "WHERE "
                SQLStr = SQLStr & " DNLine.Color_ID = Color.Color_ID and "
                SQLStr = SQLStr & " DNLine.PartCode_ID = Proj.PartCode_ID"
            End If

            SQLStr = SQLStr & " Order by DNLine.DN_Line_ID"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function SaveDNLineFirstTime() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "SET DATEFORMAT DMY;INSERT INTO DeliveryNoteLine "
            SQLStr = SQLStr & "(DN_ID, Create_Date, Transact_Date, UserID)"
            SQLStr = SQLStr & " VALUES (" & mvarDN_ID & ","
            SQLStr = SQLStr & " GetDate(),GetDate()," & mvarUserID & ")"
            SQLStr = SQLStr & ";SELECT @@identity as DN_Line_ID FROM DeliveryNoteLine"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        mvarDN_Line_ID = ds.Tables(0).Rows(0)(0)
                    End If
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Function SaveDNLine() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "INSERT INTO DeliveryNoteLine "
            SQLStr = SQLStr & "(DN_ID, PartCode_ID, "
            SQLStr = SQLStr & "Qty, Category_ID, Product_ID, "
            SQLStr = SQLStr & "WIP, Instruction, "
            SQLStr = SQLStr & "Color_ID, Dimension, "
            SQLStr = SQLStr & "Create_Date, Transact_Date, UserID)"
            SQLStr = SQLStr & " VALUES (" & mvarDN_ID & ", " & mvarLnPartCode_ID & ", "
            SQLStr = SQLStr & mvarLnQty & ", " & mvarLnCategory_ID & ", "
            SQLStr = SQLStr & mvarLnProduct_ID & ", '" & mvarLnWIP & "', "
            SQLStr = SQLStr & "'" & mvarLnInstruction & "', "
            SQLStr = SQLStr & mvarLnColor_ID & ", '" & mvarLnDimension & "', "
            SQLStr = SQLStr & " GetDate(),GetDate(), '" & mvarUserID & "')"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Function UpdateDNLine(ByVal pDN_Line_ID As String)
            Dim ds As DataSet
            Dim SQLStr As String = "Update DeliveryNoteLine SET "
            SQLStr = SQLStr & " DN_ID = " & mvarDN_ID & ","
            SQLStr = SQLStr & " PartCode_ID = " & mvarLnPartCode_ID & ","
            SQLStr = SQLStr & " Qty = " & mvarLnQty & ","
            SQLStr = SQLStr & " Category_ID = " & mvarLnCategory_ID & ","
            SQLStr = SQLStr & " Product_ID = " & mvarLnProduct_ID & ","
            SQLStr = SQLStr & " WIP = '" & mvarLnWIP & "',"
            SQLStr = SQLStr & " Instruction = '" & mvarLnInstruction & "',"
            SQLStr = SQLStr & " Color_ID = " & mvarLnColor_ID & ","
            SQLStr = SQLStr & " Dimension = '" & mvarLnDimension & "',"
            SQLStr = SQLStr & " Transact_Date = GetDate() ,"
            SQLStr = SQLStr & " UserID = '" & mvarUserID & "'  "
            SQLStr = SQLStr & " WHERE DN_Line_ID = " & pDN_Line_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
            ds.Dispose()
        End Function


#End Region

#Region " DELETE Delivery Note "
        Public Function DeleteDeliveryNote(ByVal pDN_ID As String) As Boolean
            Dim ds As DataSet
            With New DataAccess.DAccess.Access
                Dim SQLStr As String = "DELETE FROM DeliveryNoteHeader WHERE DN_ID = " & pDN_ID

                If .GetDataSet(ds, SQLStr) Then
                    SQLStr = "DELETE FROM DeliveryNoteLine WHERE DN_ID = " & pDN_ID
                    If .GetDataSet(ds, SQLStr) Then
                        Return True
                    End If
                End If
                ds.Dispose()
            End With
        End Function
#End Region

#Region " DELETE Delivery Note Line"
        Public Function DeleteDeliveryNoteLine(ByVal pDN_Line_ID As String) As Boolean
            Dim ds As DataSet
            With New DataAccess.DAccess.Access
                Dim SQLStr As String = "DELETE FROM DeliveryNoteLine WHERE DN_Line_ID = " & pDN_Line_ID

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function
#End Region

#Region "Validation"
        Public Function RecordExists(ByVal pDN_No As String, Optional ByVal pDN_ID As Integer = Nothing) As Boolean

            Dim ds As DataSet
            Dim SQLStr As String
            SQLStr = "SELECT DN_ID FROM DeliveryNoteHeader"
            SQLStr = SQLStr & " WHERE DN_No='" & pDN_No & "'"

            If pDN_ID <> Nothing And pDN_ID <> 0 Then
                SQLStr = SQLStr & " AND DN_ID<>" & pDN_ID
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

#Region "Get and Let Property for Header"

        Public Property DN_ID() As Integer
            Get
                Return mvarDN_ID
            End Get
            Set(ByVal Value As Integer)
                mvarDN_ID = Value
            End Set
        End Property

        Public Property Status() As String
            Get
                Return mvarStatus
            End Get
            Set(ByVal Value As String)
                mvarStatus = Value
            End Set
        End Property

        Public Property DN_No() As String
            Get
                Return mvarDN_No
            End Get
            Set(ByVal Value As String)
                mvarDN_No = Value
            End Set
        End Property

        Public Property WO_ID() As Integer
            Get
                Return mvarWO_ID
            End Get
            Set(ByVal Value As Integer)
                mvarWO_ID = Value
            End Set
        End Property

        Public Property Supplier_ID() As Integer
            Get
                Return mvarSupplier_ID
            End Get
            Set(ByVal Value As Integer)
                mvarSupplier_ID = Value
            End Set
        End Property

        Public Property Completion_Date() As String
            Get
                Return mvarCompletion_Date
            End Get
            Set(ByVal Value As String)
                mvarCompletion_Date = Value
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

        Public Property Process_Type() As String
            Get
                Return mvarProcess_Type
            End Get
            Set(ByVal Value As String)
                mvarProcess_Type = Value
            End Set
        End Property

        Public Property RevRefDNID() As Integer
            Get
                Return mvarRevRefDNID
            End Get
            Set(ByVal Value As Integer)
                mvarRevRefDNID = Value
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

#Region "Get and Let Property for Line"
        Public Property DN_Line_ID() As Integer
            Get
                Return DN_Line_ID
            End Get
            Set(ByVal Value As Integer)
                DN_Line_ID = Value
            End Set
        End Property

        Public Property LnDN_ID() As Integer
            Get
                Return mvarLnDN_ID
            End Get
            Set(ByVal Value As Integer)
                mvarLnDN_ID = Value
            End Set
        End Property

        Public Property LnPartCode_ID() As Integer
            Get
                Return mvarLnPartCode_ID
            End Get
            Set(ByVal Value As Integer)
                mvarLnPartCode_ID = Value
            End Set
        End Property

        Public Property LnQty() As Integer
            Get
                Return mvarLnQty
            End Get
            Set(ByVal Value As Integer)
                mvarLnQty = Value
            End Set
        End Property

        Public Property LnCategory_ID() As Integer
            Get
                Return mvarLnCategory_ID
            End Get
            Set(ByVal Value As Integer)
                mvarLnCategory_ID = Value
            End Set
        End Property

        Public Property LnProduct_ID() As Integer
            Get
                Return mvarLnProduct_ID
            End Get
            Set(ByVal Value As Integer)
                mvarLnProduct_ID = Value
            End Set
        End Property

        Public Property LnWIP() As String
            Get
                Return mvarLnWIP
            End Get
            Set(ByVal Value As String)
                mvarLnWIP = Value
            End Set
        End Property

        Public Property LnInstruction() As String
            Get
                Return mvarLnInstruction
            End Get
            Set(ByVal Value As String)
                mvarLnInstruction = Value
            End Set
        End Property

        Public Property LnColor_ID() As Integer
            Get
                Return mvarLnColor_ID
            End Get
            Set(ByVal Value As Integer)
                mvarLnColor_ID = Value
            End Set
        End Property

        Public Property LnDimension() As String
            Get
                Return mvarLnDimension
            End Get
            Set(ByVal Value As String)
                mvarLnDimension = Value
            End Set
        End Property

        Public Property LnCreate_Date() As String
            Get
                Return mvarLnCreate_Date
            End Get
            Set(ByVal Value As String)
                mvarLnCreate_Date = Value
            End Set
        End Property

        Public Property LnTransact_Date() As String
            Get
                Return mvarLnTransact_Date
            End Get
            Set(ByVal Value As String)
                mvarLnTransact_Date = Value
            End Set
        End Property

        Public Property LnUserID() As Integer
            Get
                Return mvarLnUserID
            End Get
            Set(ByVal Value As Integer)
                mvarLnUserID = Value
            End Set
        End Property

#End Region

#Region " Delivery Note Report "
        Public Function GetDeliveryNoteRpt(ByRef ds As DataSet, ByVal pDN_ID As String)
            Dim SQLStr As String

            SQLStr = "SELECT dnh.*, dnl.*, s.Supplier_Name, s.Address, s.Postal, woh.WO_No, pn.Name as ProductName, cn.Color_Name "
            SQLStr = SQLStr & " FROM DeliveryNoteHeader dnh, WorkOrderHeader woh, DeliveryNoteLine dnl, Supplier s, Product pn, Color cn "
            SQLStr = SQLStr & " where dnh.WO_ID = woh.WO_ID and "
            SQLStr = SQLStr & " dnh.Supplier_ID = s.Supplier_ID and "
            SQLStr = SQLStr & " dnh.DN_ID = dnl.DN_ID and "
            SQLStr = SQLStr & " dnl.Product_ID = pn.Product_ID and "
            'SQLStr = SQLStr & " dnl.Material_ID = mn.Material_ID and "
            SQLStr = SQLStr & " dnl.Color_ID = cn.Color_ID  "

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function
#End Region

    End Class

End Namespace
