
Namespace WorkPlanBusRules

    Public Class WorkPlanBusLogic

#Region "Variables Initialization"
        ' Header
        Private mvarWP_ID As Integer
        Private mvarWP_No As String
        Private mvarWO_ID As Integer
        Private mvarStatus As String
        Private mvarBox As String
        Private mvarKey_Type As Integer
        Private mvarHeight As String
        Private mvarWidth As String
        Private mvarDepth As String
        Private mvarDraw_No As Integer
        Private mvarQty As String
        Private mvarRemark As String
        Private mvarET_PowderCoat As String
        Private mvarET_MetalProcess As String
        Private mvarET_Assembly As String
        Private mvarET_Inspection As String
        Private mvarET_Completion As String
        Private mvarAct_PowderCoat As String
        Private mvarAct_MetalProcess As String
        Private mvarAct_Assembly As String
        Private mvarAct_Inspection As String
        Private mvarAct_Completion As String
        Private mvarRevRefWPID As Integer
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As Integer

        ' Line
        Private mvarWPLine_ID As Integer
        Private mvarLnWP_ID As Integer
        Private mvarLnCategory_ID As Integer
        Private mvarLnProduct_ID As Integer
        Private mvarLnPartCode_ID As Integer
        Private mvarLnMaterial_ID As Integer
        Private mvarLnColor_ID As Integer
        Private mvarLnQty As String
        Private mvarLnDescription As String
        Private mvarLnWidth As Double
        Private mvarLnLength As Double
        Private mvarLnThick As Double
        Private mvarLnTotArea As Decimal
        Private mvarLnPCPrice As Decimal
        Private mvarLnCutting As String
        Private mvarLnPunching As String
        Private mvarLnBending As String
        Private mvarLnPowerPress As String
        Private mvarLnWelding As String
        Private mvarLnPCProcess As String
        Private mvarLnRemark As String
        Private mvarLnCreate_Date As String
        Private mvarLnTransact_Date As String
        Private mvarLnUserID As Integer

#End Region

#Region "Work Plan Header"

        Public Function GetWPHeader(ByRef ds As DataSet, Optional ByVal pWP_ID As String = "") As Boolean
            Dim SQLStr As String

            If Len(pWP_ID) > 0 Then
                SQLStr = "SET DATEFORMAT dmy;SELECT WP.*,UP.Login_Id FROM WorkPlanHeader WP"
                SQLStr = SQLStr & " LEFT JOIN UserProfile UP on (WP.UserId=UP.User_Id)"
                SQLStr = SQLStr & " WHERE WP_ID =" & pWP_ID
            Else
                SQLStr = "SET DATEFORMAT dmy;SELECT WP.*,UP.Login_Id FROM WorkPlanHeader WP"
                SQLStr = SQLStr & " LEFT JOIN UserProfile UP on (WP.UserId=UP.User_Id)"
            End If

            SQLStr = SQLStr & " Order by WP_No"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetWorkPlanHeader(ByRef ds As DataSet, ByVal pWP_ID As String) As Boolean
            Dim SQLStr As String

            SQLStr = "SET DATEFORMAT dmy;SELECT WP.*,UP.Login_Id FROM WorkPlanHeader WP "
            SQLStr = SQLStr & " LEFT JOIN UserProfile UP on (WP.UserId=UP.User_Id)"
            SQLStr = SQLStr & "WHERE WP_ID =" & pWP_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function LoadList(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "SELECT * FROM WorkPlanHeader"
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function Load(Optional ByVal pWP_ID As String = "") As Boolean
            With New DataAccess.DAccess.Access
                Dim ds As DataSet
                Dim SQLStr As String = "SELECT * FROM WorkPlanHeader"

                If pWP_ID <> "" Then
                    SQLStr = SQLStr & " WHERE WP_ID =" & pWP_ID
                End If

                If .GetDataSet(ds, SQLStr) Then
                    Dim row As DataRow = ds.Tables(0).Rows(0)

                    If Not row.IsNull("WP_No") Then
                        WP_No = row("WP_No").ToString()
                    Else
                        WP_No = ""
                    End If

                    If Not row.IsNull("WO_ID") Then
                        WO_ID = row("WO_ID").ToString()
                    Else
                        WO_ID = ""
                    End If

                    If Not row.IsNull("Status") Then
                        Status = row("Status").ToString()
                    Else
                        Status = ""
                    End If

                    If Not row.IsNull("Box") Then
                        Box = row("Box").ToString()
                    Else
                        Box = ""
                    End If

                    If Not row.IsNull("Key_Type") Then
                        Key_Type = row("Key_Type").ToString()
                    Else
                        Key_Type = ""
                    End If

                    If Not row.IsNull("Height") Then
                        Height = row("Height").ToString()
                    Else
                        Height = ""
                    End If

                    If Not row.IsNull("Width") Then
                        Width = row("Width").ToString()
                    Else
                        Width = ""
                    End If

                    If Not row.IsNull("Depth") Then
                        Depth = row("Depth").ToString()
                    Else
                        Depth = ""
                    End If

                    If Not row.IsNull("Draw_No") Then
                        Draw_No = row("Draw_No").ToString()
                    Else
                        Draw_No = ""
                    End If

                    If Not row.IsNull("Qty") Then
                        Qty = row("Qty").ToString()
                    Else
                        Qty = ""
                    End If

                    If Not row.IsNull("Remark") Then
                        Remark = row("Remark").ToString()
                    Else
                        Remark = ""
                    End If

                    If Not row.IsNull("ET_PowderCoat") Then
                        ET_PowderCoat = row("ET_PowderCoat").ToString()
                    Else
                        ET_PowderCoat = ""
                    End If

                    If Not row.IsNull("ET_MetalProcess") Then
                        ET_MetalProcess = row("ET_MetalProcess").ToString()
                    Else
                        ET_MetalProcess = ""
                    End If

                    If Not row.IsNull("ET_Assembly") Then
                        ET_Assembly = row("ET_Assembly").ToString()
                    Else
                        ET_Assembly = ""
                    End If

                    If Not row.IsNull("ET_Inspection") Then
                        ET_Inspection = row("ET_Inspection").ToString()
                    Else
                        ET_Inspection = ""
                    End If

                    If Not row.IsNull("ET_Completion") Then
                        ET_Completion = row("ET_Completion").ToString()
                    Else
                        ET_Completion = ""
                    End If

                    If Not row.IsNull("Act_PowderCoat") Then
                        Act_PowderCoat = row("Act_PowderCoat").ToString()
                    Else
                        Act_PowderCoat = ""
                    End If

                    If Not row.IsNull("Act_MetalProcess") Then
                        Act_MetalProcess = row("Act_MetalProcess").ToString()
                    Else
                        Act_MetalProcess = ""
                    End If

                    If Not row.IsNull("Act_Assembly") Then
                        Act_Assembly = row("Act_Assembly").ToString()
                    Else
                        Act_Assembly = ""
                    End If

                    If Not row.IsNull("Act_Inspection") Then
                        Act_Inspection = row("Act_Inspection").ToString()
                    Else
                        Act_Inspection = ""
                    End If

                    If Not row.IsNull("Act_Completion") Then
                        Act_Completion = row("Act_Completion").ToString()
                    Else
                        Act_Completion = ""
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

        Public Function SaveWorkPlanHeader() As Boolean
            Dim dsWorkPlanHeader As DataSet
            Dim SQLstr As String

            SQLstr = "set dateformat dmy;INSERT INTO WorkPlanHeader (WP_No"
            SQLstr = SQLstr & ", WO_ID, Status, Box, Key_Type"
            SQLstr = SQLstr & ", Height, Width, Depth, Draw_No"
            SQLstr = SQLstr & ", Qty, Remark"
            SQLstr = SQLstr & ", ET_PowderCoat, ET_MetalProcess, ET_Assembly"
            SQLstr = SQLstr & ", ET_Inspection, ET_Completion"
            SQLstr = SQLstr & ", Act_PowderCoat, Act_MetalProcess, Act_Assembly"
            SQLstr = SQLstr & ", Act_Inspection, Act_Completion"
            SQLstr = SQLstr & ", RevRefWPID, Create_Date,Transact_Date,UserID) VALUES "
            SQLstr = SQLstr & "('" & mvarWP_No & "', " & mvarWO_ID & ", "
            SQLstr = SQLstr & "'" & mvarStatus & "', '" & mvarBox & "',"
            SQLstr = SQLstr & mvarKey_Type & ", " & mvarHeight & ","
            SQLstr = SQLstr & mvarWidth & ", " & mvarDepth & ","
            SQLstr = SQLstr & mvarDraw_No & ", " & mvarQty & ","
            SQLstr = SQLstr & "'" & mvarRemark & "', '" & mvarET_PowderCoat & "',"
            SQLstr = SQLstr & "'" & mvarET_MetalProcess & "', '" & mvarET_Assembly & "',"
            SQLstr = SQLstr & "'" & mvarET_Inspection & "', '" & mvarET_Completion & "',"
            SQLstr = SQLstr & "'" & mvarAct_PowderCoat & "',"
            SQLstr = SQLstr & "'" & mvarAct_MetalProcess & "', '" & mvarAct_Assembly & "',"
            SQLstr = SQLstr & "'" & mvarAct_Inspection & "', '" & mvarAct_Completion & "',"
            SQLstr = SQLstr & mvarRevRefWPID & ", Getdate(), GetDate(),"
            SQLstr = SQLstr & "'" & mvarUserID & "')"
            SQLstr = SQLstr & ";SELECT @@identity as WP_ID FROM WorkPlanHeader"

            With New DataAccess.DAccess.Access
                If .GetDataSet(dsWorkPlanHeader, SQLstr) Then
                    If dsWorkPlanHeader.Tables(0).Rows.Count > 0 Then
                        mvarWP_ID = dsWorkPlanHeader.Tables(0).Rows(0)(0)
                    End If
                    Return True
                End If
            End With
            dsWorkPlanHeader.Dispose()
        End Function

        Public Function UpdateWorkPlanHeader(ByVal pWP_ID As String) As Boolean
            Dim dsWorkPlanHeader As DataSet
            Dim SQLStr As String

            SQLStr = "set dateformat dmy;UPDATE WorkPlanHeader SET "
            SQLStr = SQLStr & " WP_No = '" & mvarWP_No & "',"
            SQLStr = SQLStr & " WO_ID = " & mvarWO_ID & ","
            SQLStr = SQLStr & " Status = '" & mvarStatus & "',"
            SQLStr = SQLStr & " Box = '" & mvarBox & "',"
            SQLStr = SQLStr & " Key_Type = " & mvarKey_Type & ","
            SQLStr = SQLStr & " Height = " & mvarHeight & ","
            SQLStr = SQLStr & " Width = " & mvarWidth & ","
            SQLStr = SQLStr & " Depth = " & mvarDepth & ","
            SQLStr = SQLStr & " Draw_No = " & mvarDraw_No & ","
            SQLStr = SQLStr & " Qty = " & mvarQty & ","
            SQLStr = SQLStr & " Remark = '" & mvarRemark & "',"
            SQLStr = SQLStr & " ET_PowderCoat = '" & mvarET_PowderCoat & "',"
            SQLStr = SQLStr & " ET_MetalProcess = '" & mvarET_MetalProcess & "',"
            SQLStr = SQLStr & " ET_Assembly = '" & mvarET_Assembly & "',"
            SQLStr = SQLStr & " ET_Inspection = '" & mvarET_Inspection & "',"
            SQLStr = SQLStr & " ET_Completion = '" & mvarET_Completion & "',"
            SQLStr = SQLStr & " Act_PowderCoat = '" & mvarAct_PowderCoat & "',"
            SQLStr = SQLStr & " Act_MetalProcess = '" & mvarAct_MetalProcess & "',"
            SQLStr = SQLStr & " Act_Assembly = '" & mvarAct_Assembly & "',"
            SQLStr = SQLStr & " Act_Inspection = '" & mvarAct_Inspection & "',"
            SQLStr = SQLStr & " Act_Completion = '" & mvarAct_Completion & "',"
            SQLStr = SQLStr & " RevRefWPID = " & mvarRevRefWPID & ","
            SQLStr = SQLStr & " Transact_Date = GetDate(), "
            SQLStr = SQLStr & " UserID = '" & mvarUserID & "' WHERE "
            SQLStr = SQLStr & " WP_ID = " & pWP_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(dsWorkPlanHeader, SQLStr) Then
                    Return True
                End If
            End With
            dsWorkPlanHeader.Dispose()
        End Function

        Public Function UpdateWorkPlanHeaderStatus() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "UPDATE WorkPlanHeader SET "
            SQLStr = SQLStr & " Status = '" & mvarStatus & "' WHERE WP_ID = " & mvarWP_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
            ds.Dispose()
        End Function

        Public Function IsRevisedWP(ByRef dsSub As DataSet) As Boolean
            Dim ds As DataSet
            Dim SQLstr As String = "SELECT RevRefWPID FROM WorkPlanHeader "
            SQLstr = SQLstr & " WHERE WP_ID = " & mvarWP_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLstr) Then
                    If Not IsDBNull(ds.Tables(0).Rows(0)("RevRefWPID")) Then
                        If ds.Tables(0).Rows(0)("RevRefWPID") = 0 Then
                            Return False
                        Else
                            Dim SubSQLStr As String = "SELECT WP_ID, WP_NO FROM WorkPlanHeader "
                            SubSQLStr = SubSQLStr & " WHERE WP_ID = " & ds.Tables(0).Rows(0)("RevRefWPID")

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

        Public Function CountNoOfRevisedWP() As Integer
            Dim ds As DataSet
            Dim SQLstr As String = "SELECT COUNT(*) FROM WorkPlanHeader "
            SQLstr = SQLstr & " WHERE RevRefWPID = " & mvarRevRefWPID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLstr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        CountNoOfRevisedWP = ds.Tables(0).Rows(0)(0) + 1
                    Else
                        CountNoOfRevisedWP = 1
                    End If
                End If
            End With
            ds.Dispose()
        End Function

        Public Function CheckExistingWPNo() As Boolean
            Dim ds As DataSet
            Dim SQLstr As String = "SELECT WP_NO FROM WorkPlanHeader "
            SQLstr = SQLstr & " WHERE WP_NO = '" & mvarWP_No & "'"

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

        'Initial saving. To get the WP_ID
        Public Function SaveWPNo() As Boolean
            Dim dsWP As DataSet
            With New DataAccess.DAccess.Access
                Dim SQLstr As String = "SET DATEFORMAT dmy;INSERT INTO WorkPlanHeader "
                SQLstr = SQLstr & "(WP_No, Status, WO_ID , Create_Date,Transact_Date,UserID) "
                SQLstr = SQLstr & " VALUES ('" & mvarWP_No & "','" & mvarStatus & "',"
                SQLstr = SQLstr & "mvarWO_ID, Getdate(), GetDate(),"
                SQLstr = SQLstr & "'" & mvarUserID & "') "
                SQLstr = SQLstr & ";SELECT @@identity as WP_ID FROM WorkPlanHeader"

                If .GetDataSet(dsWP, SQLstr) Then
                    If dsWP.Tables(0).Rows.Count > 0 Then
                        mvarWP_ID = dsWP.Tables(0).Rows(0)(0)
                    End If
                    Return True
                End If
                dsWP.Dispose()
            End With
        End Function
#End Region


#Region "Work Plan Line"
        Public Function GetWPLine_ByLineID(ByRef ds As DataSet, ByVal pWPLine_ID As String) As Boolean
            Dim SQLStr As String

            SQLStr = "SET DATEFORMAT dmy;SELECT * FROM WorkPlanLine "
            SQLStr = SQLStr & "WHERE WPLine_ID =" & pWPLine_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetWPLine(ByRef ds As DataSet, Optional ByVal pWP_ID As String = "") As Boolean
            Dim SQLStr As String

            If Len(pWP_ID) > 0 Then
                SQLStr = "SET DATEFORMAT dmy;SELECT * FROM WorkPlanLine "
                SQLStr = SQLStr & "WHERE WP_ID =" & pWP_ID
            Else
                SQLStr = "SET DATEFORMAT dmy;SELECT * FROM WorkPlanLine"
            End If

            SQLStr = SQLStr & " Order by WPLine_ID"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function GetWPLine_PowderCoatPricing(ByRef ds As DataSet, ByVal pWP_ID As String)
            Dim SQLStr As String

            SQLStr = "SELECT wpl.WPLine_ID AS wpline_id, wpl.WP_ID AS WP_ID, wpl.PartCode_ID AS PartCode_ID, wpl.Material_ID AS Material_ID, wpl.Color_ID AS Color_ID, "
            SQLStr = SQLStr & " wpl.Qty AS Qty, wpl.Description AS Description, wpl.Cutting AS Cutting, wpl.Punching AS Punching, wpl.Bending AS Bending, "
            SQLStr = SQLStr & " wpl.PowerPress AS PowerPress, wpl.Welding AS Welding, wpl.PCProcess AS PCProcess, wpl.Remark AS Remark, wpl.Width AS Width, (wpl.PCPrice * wpl.Qty) AS QtyPrice, "
            SQLStr = SQLStr & " wpl.Length AS Length, wpl.thick, wpl.TotalArea AS TotalArea, wpl.PCPrice AS PCPrice, pc.PartCodeName AS PartCodeName, Product.Name AS Material, Color.Color_Name as colorname, WorkOrderHeader.WO_No, "
            SQLStr = SQLStr & " wph.Height as WPHHeight, wph.Width as WPHWidth"
            SQLStr = SQLStr & " FROM WorkPlanLine wpl INNER JOIN PartCode pc ON wpl.PartCode_ID = pc.PartCode_ID INNER JOIN "
            SQLStr = SQLStr & " Product ON wpl.Material_ID = Product.Product_ID Inner Join color on wpl.color_id=color.color_id "
            SQLStr = SQLStr & " INNER JOIN WorkPlanHeader wph ON wpl.WP_ID = wph.WP_ID INNER JOIN WorkOrderHeader ON wph.WO_ID = WorkOrderHeader.WO_ID"
            SQLStr = SQLStr & " WHERE (Product.Raw_Material = '1' OR Product.Raw_Material = '0') "
            SQLStr = SQLStr & " and wpl.wp_id=" & Integer.Parse(pWP_ID)

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then

                End If
            End With

        End Function

        Public Function GetWPLine_Display(ByRef ds As DataSet, Optional ByVal pWP_ID As String = "") As Boolean
            Dim SQLStr As String

            If Len(pWP_ID) > 0 Then
                SQLStr = "SELECT WPLine.* From WorkPlanLine WPLine "
                'SQLStr = "SELECT Cat.Name as Category, Prod.Name as Product, WPLine.* "
                'SQLStr = SQLStr & " FROM WorkPlanLine WPLine, Category Cat, Product Prod "
                'SQLStr = SQLStr & "WHERE WPLine.Category_ID = Cat.Category_ID and "
                'SQLStr = SQLStr & " WPLine.Product_ID = Prod.Product_ID and "
                SQLStr = SQLStr & " WHERE WPLine.WP_ID = " & pWP_ID
            Else
                SQLStr = "SELECT WPLine.* From WorkPlanLine WPLine "
                'SQLStr = "SELECT Cat.Name as Category, Prod.Name as Product, WPLine.* "
                'SQLStr = SQLStr & " FROM WorkPlanLine WPLine, Category Cat, Product Prod "
                'SQLStr = SQLStr & "WHERE WPLine.Category_ID = Cat.Category_ID and "
                'SQLStr = SQLStr & " WHERE WPLine.Product_ID = Prod.Product_ID"
            End If

            SQLStr = SQLStr & " Order by WPLine.WPLine_ID"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function SaveWPLineFirstTime() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "SET DATEFORMAT DMY;INSERT INTO WorkPlanLine "
            SQLStr = SQLStr & "(WP_ID, Create_Date, Transact_Date, UserID)"
            SQLStr = SQLStr & " VALUES (" & mvarWP_ID & ","
            SQLStr = SQLStr & " GetDate(),GetDate()," & mvarUserID & ")"
            SQLStr = SQLStr & ";SELECT @@identity as WPLine_ID FROM WorkPlanLine"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        mvarWPLine_ID = ds.Tables(0).Rows(0)(0)
                    End If
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Function SaveWPLine() As Boolean
            Dim ds As DataSet
            Dim SQLStr As String = "set dateformat dmy;INSERT INTO WorkPlanLine "
            SQLStr = SQLStr & "(WP_ID, Category_ID, "
            SQLStr = SQLStr & "Product_ID, PartCode_ID, Material_ID, "
            SQLStr = SQLStr & "Color_ID, Qty, Width, Length, Thick, TotalArea, PCPrice,"
            SQLStr = SQLStr & "Description, Cutting, Punching, Bending, "
            SQLStr = SQLStr & "PowerPress, Welding, PCProcess, "
            SQLStr = SQLStr & "Create_Date, Transact_Date, UserID)"
            SQLStr = SQLStr & " VALUES (" & mvarWP_ID & ", " & mvarLnCategory_ID & ", "
            SQLStr = SQLStr & mvarLnProduct_ID & ", " & mvarLnPartCode_ID & "," & mvarLnMaterial_ID & ", "
            SQLStr = SQLStr & mvarLnColor_ID & ", " & mvarLnQty & ", " & mvarLnWidth & ", " & mvarLnLength & ", " & mvarLnThick & ", "
            SQLStr = SQLStr & mvarLnTotArea & ", " & mvarLnPCPrice & ", '"
            SQLStr = SQLStr & Replace(mvarLnDescription, "'", "''") & "', '" & mvarLnCutting & "', '" & mvarLnPunching & "', '"
            SQLStr = SQLStr & mvarLnBending & "', '" & mvarLnPowerPress & "', '"
            SQLStr = SQLStr & mvarLnWelding & "', '" & mvarLnPCProcess & "', "
            SQLStr = SQLStr & " GetDate(),GetDate(), '" & mvarUserID & "')"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function

        Public Function UpdateWPLine()
            Dim ds As DataSet
            Dim SQLStr As String = "set dateformat dmy;Update WorkPlanLine SET "
            SQLStr = SQLStr & " WP_ID = " & mvarWP_ID & ","
            SQLStr = SQLStr & " Category_ID = " & mvarLnCategory_ID & ","
            SQLStr = SQLStr & " Product_ID = " & mvarLnProduct_ID & ","
            SQLStr = SQLStr & " PartCode_ID = " & mvarLnPartCode_ID & ","
            SQLStr = SQLStr & " Material_ID = " & mvarLnMaterial_ID & ","
            SQLStr = SQLStr & " Color_ID = " & mvarLnColor_ID & ","
            SQLStr = SQLStr & " Qty = " & mvarLnQty & ","
            SQLStr = SQLStr & " Description = '" & mvarLnDescription & "', "
            SQLStr = SQLStr & " Width = " & mvarLnWidth & ","
            SQLStr = SQLStr & " Length = " & mvarLnLength & ","
            SQLStr = SQLStr & " Thick = " & mvarLnThick & ","
            SQLStr = SQLStr & " TotalArea = " & mvarLnTotArea & ","
            SQLStr = SQLStr & " PCPrice = " & mvarLnPCPrice & ","
            SQLStr = SQLStr & " Cutting = '" & mvarLnCutting & "',"
            SQLStr = SQLStr & " Punching = '" & mvarLnPunching & "',"
            SQLStr = SQLStr & " Bending = '" & mvarLnBending & "',"
            SQLStr = SQLStr & " PowerPress = '" & mvarLnPowerPress & "',"
            SQLStr = SQLStr & " Welding = '" & mvarLnWelding & "',"
            SQLStr = SQLStr & " PCProcess = '" & mvarLnPCProcess & "',"
            SQLStr = SQLStr & " Remark = '" & mvarLnRemark & "',"
            SQLStr = SQLStr & " Transact_Date = GetDate() ,"
            SQLStr = SQLStr & " UserID = " & mvarUserID & "  "
            SQLStr = SQLStr & " WHERE WPLine_ID = " & mvarWPLine_ID

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
            ds.Dispose()
        End Function


#End Region


#Region " DELETE Work Plan "
        Public Function DeleteWorkPlan(ByVal pWP_ID As String) As Boolean
            Dim ds As DataSet
            With New DataAccess.DAccess.Access
                Dim SQLStr As String = "DELETE FROM WorkPlanHeader WHERE WP_ID = " & pWP_ID

                If .GetDataSet(ds, SQLStr) Then
                    SQLStr = "DELETE FROM WorkPlanLine WHERE WP_ID = " & pWP_ID
                    If .GetDataSet(ds, SQLStr) Then
                        Return True
                    End If
                End If
                ds.Dispose()
            End With
        End Function
#End Region

#Region " DELETE Work Plan Line"
        Public Function DeleteWorkPlanLine(ByVal pWPLine_ID As String) As Boolean
            Dim ds As DataSet
            With New DataAccess.DAccess.Access
                Dim SQLStr As String = "DELETE FROM WorkPlanLine WHERE WPLine_ID = " & pWPLine_ID

                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
                ds.Dispose()
            End With
        End Function
#End Region

#Region "Validation"
        Public Function RecordExists(ByVal pWP_No As String, Optional ByVal pWP_ID As Integer = Nothing) As Boolean

            Dim ds As DataSet
            Dim SQLStr As String
            SQLStr = "SELECT WP_ID FROM WorkPlanHeader"
            SQLStr = SQLStr & " WHERE WP_No='" & pWP_No & "'"

            If pWP_ID <> Nothing And pWP_ID <> 0 Then
                SQLStr = SQLStr & " AND WP_ID<>" & pWP_ID
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

        Public Property WP_ID() As Integer
            Get
                Return mvarWP_ID
            End Get
            Set(ByVal Value As Integer)
                mvarWP_ID = Value
            End Set
        End Property

        Public Property WP_No() As String
            Get
                Return mvarWP_No
            End Get
            Set(ByVal Value As String)
                mvarWP_No = Value
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

        Public Property Status() As String
            Get
                Return mvarStatus
            End Get
            Set(ByVal Value As String)
                mvarStatus = Value
            End Set
        End Property

        Public Property Box() As String
            Get
                Return mvarBox
            End Get
            Set(ByVal Value As String)
                mvarBox = Value
            End Set
        End Property

        Public Property Key_Type() As Integer
            Get
                Return mvarKey_Type
            End Get
            Set(ByVal Value As Integer)
                mvarKey_Type = Value
            End Set
        End Property

        Public Property Height() As String
            Get
                Return mvarHeight
            End Get
            Set(ByVal Value As String)
                mvarHeight = Value
            End Set
        End Property

        Public Property Width() As String
            Get
                Return mvarWidth
            End Get
            Set(ByVal Value As String)
                mvarWidth = Value
            End Set
        End Property

        Public Property Depth() As String
            Get
                Return mvarDepth
            End Get
            Set(ByVal Value As String)
                mvarDepth = Value
            End Set
        End Property

        Public Property Draw_No() As Integer
            Get
                Return mvarDraw_No
            End Get
            Set(ByVal Value As Integer)
                mvarDraw_No = Value
            End Set
        End Property

        Public Property Qty() As String
            Get
                Return mvarQty
            End Get
            Set(ByVal Value As String)
                mvarQty = Value
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

        Public Property ET_PowderCoat() As String
            Get
                Return mvarET_PowderCoat
            End Get
            Set(ByVal Value As String)
                mvarET_PowderCoat = Value
            End Set
        End Property

        Public Property ET_MetalProcess() As String
            Get
                Return mvarET_MetalProcess
            End Get
            Set(ByVal Value As String)
                mvarET_MetalProcess = Value
            End Set
        End Property

        Public Property ET_Assembly() As String
            Get
                Return mvarET_Assembly
            End Get
            Set(ByVal Value As String)
                mvarET_Assembly = Value
            End Set
        End Property

        Public Property ET_Inspection() As String
            Get
                Return mvarET_Inspection
            End Get
            Set(ByVal Value As String)
                mvarET_Inspection = Value
            End Set
        End Property

        Public Property ET_Completion() As String
            Get
                Return mvarET_Completion
            End Get
            Set(ByVal Value As String)
                mvarET_Completion = Value
            End Set
        End Property

        Public Property Act_PowderCoat() As String
            Get
                Return mvarAct_PowderCoat
            End Get
            Set(ByVal Value As String)
                mvarAct_PowderCoat = Value
            End Set
        End Property

        Public Property Act_MetalProcess() As String
            Get
                Return mvarAct_MetalProcess
            End Get
            Set(ByVal Value As String)
                mvarAct_MetalProcess = Value
            End Set
        End Property

        Public Property Act_Assembly() As String
            Get
                Return mvarAct_Assembly
            End Get
            Set(ByVal Value As String)
                mvarAct_Assembly = Value
            End Set
        End Property

        Public Property Act_Inspection() As String
            Get
                Return mvarAct_Inspection
            End Get
            Set(ByVal Value As String)
                mvarAct_Inspection = Value
            End Set
        End Property

        Public Property Act_Completion() As String
            Get
                Return mvarAct_Completion
            End Get
            Set(ByVal Value As String)
                mvarAct_Completion = Value
            End Set
        End Property

        Public Property RevRefWPID() As Integer
            Get
                Return mvarRevRefWPID
            End Get
            Set(ByVal Value As Integer)
                mvarRevRefWPID = Value
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
        Public Property WPLine_ID() As Integer
            Get
                Return mvarWPLine_ID
            End Get
            Set(ByVal Value As Integer)
                mvarWPLine_ID = Value
            End Set
        End Property

        Public Property LnWP_ID() As Integer
            Get
                Return mvarLnWP_ID
            End Get
            Set(ByVal Value As Integer)
                mvarLnWP_ID = Value
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

        Public Property LnPartCode_ID() As Integer
            Get
                Return mvarLnPartCode_ID
            End Get
            Set(ByVal Value As Integer)
                mvarLnPartCode_ID = Value
            End Set
        End Property

        Public Property LnMaterial_ID() As Integer
            Get
                Return mvarLnMaterial_ID
            End Get
            Set(ByVal Value As Integer)
                mvarLnMaterial_ID = Value
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

        Public Property LnQty() As Integer
            Get
                Return mvarLnQty
            End Get
            Set(ByVal Value As Integer)
                mvarLnQty = Value
            End Set
        End Property

        Public Property LnDescription() As String
            Get
                Return mvarLnDescription
            End Get
            Set(ByVal Value As String)
                mvarLnDescription = Value
            End Set
        End Property

        Public Property LnWidth() As Double
            Get
                Return mvarLnWidth
            End Get
            Set(ByVal Value As Double)
                mvarLnWidth = Value
            End Set
        End Property
        Public Property LnLength() As Double
            Get
                Return mvarLnLength
            End Get
            Set(ByVal Value As Double)
                mvarLnLength = Value
            End Set
        End Property
        Public Property LnThick() As Double
            Get
                Return mvarLnThick
            End Get
            Set(ByVal Value As Double)
                mvarLnThick = Value
            End Set
        End Property
        Public Property LnTotArea() As Decimal
            Get
                Return mvarLnTotArea
            End Get
            Set(ByVal Value As Decimal)
                mvarLnTotArea = Value
            End Set
        End Property
        Public Property LnPCPrice() As Decimal
            Get
                Return mvarLnPCPrice
            End Get
            Set(ByVal Value As Decimal)
                mvarLnPCPrice = Value
            End Set
        End Property
        Public Property LnCutting() As String
            Get
                Return mvarLnCutting
            End Get
            Set(ByVal Value As String)
                mvarLnCutting = Value
            End Set
        End Property

        Public Property LnPunching() As String
            Get
                Return mvarLnPunching
            End Get
            Set(ByVal Value As String)
                mvarLnPunching = Value
            End Set
        End Property

        Public Property LnBending() As String
            Get
                Return mvarLnBending
            End Get
            Set(ByVal Value As String)
                mvarLnBending = Value
            End Set
        End Property

        Public Property LnPowerPress() As String
            Get
                Return mvarLnPowerPress
            End Get
            Set(ByVal Value As String)
                mvarLnPowerPress = Value
            End Set
        End Property

        Public Property LnWelding() As String
            Get
                Return mvarLnWelding
            End Get
            Set(ByVal Value As String)
                mvarLnWelding = Value
            End Set
        End Property

        Public Property LnPCProcess() As String
            Get
                Return mvarLnPCProcess
            End Get
            Set(ByVal Value As String)
                mvarLnPCProcess = Value
            End Set
        End Property

        Public Property LnRemark() As String
            Get
                Return mvarLnRemark
            End Get
            Set(ByVal Value As String)
                mvarLnRemark = Value
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

#Region " Work Plan Report "
        Public Function GetWPReport(ByRef ds As DataSet, ByVal pWP_ID As String)
            Dim SQLStr As String

            'SQLStr = "SELECT wph.*, wpl.*, wph.qty as HeaderQty, wpl.qty as LineQty, wpl.Cutting as Cutting, wpl.Bending as Bending, woh.WO_No, d.Drawing_No, k.Key_Name, pn.Name as ProductName, mn.Material_Name, cn.Color_Name, up.Name as User_Name "
            'SQLStr = SQLStr & " FROM WorkPlanHeader wph, WorkPlanLine wpl, WorkOrderHeader woh, DrawingNo d, KeyTypes k, Product pn, Material mn, Color cn, UserProfile up "
            'SQLStr = SQLStr & " where wph.WO_ID = " & pWP_ID
            SQLStr = SQLStr & " SELECT wpl.WPLine_ID AS wpline_id, wpl.WP_ID AS WP_ID, wpl.PartCode_ID AS PartCode_ID, wpl.Material_ID AS Material_ID, wpl.Color_ID AS Color_ID, "
            SQLStr = SQLStr & " wpl.Qty AS LineQty, wpl.Description AS Description, wpl.Cutting AS Cutting, wpl.Punching AS Punching, wpl.Bending AS Bending, "
            SQLStr = SQLStr & " wpl.PowerPress AS PowerPress, wpl.Welding AS Welding, wpl.PCProcess AS PCProcess, wpl.Remark AS Remark, wpl.Width AS Width, "
            SQLStr = SQLStr & " wpl.PCPrice * wpl.Qty AS QtyPrice, wpl.Length AS Length, wpl.Thick, wpl.TotalArea AS TotalArea, wpl.PCPrice AS PCPrice, "
            SQLStr = SQLStr & " pc.PartCodeName AS PartCodeName, Product.Name AS Material_name, c.Color_Name AS color_name, woh.WO_No, wph.Height AS WPHHeight, "
            SQLStr = SQLStr & " wph.Width AS WPHWidth, wph.Depth AS WPHDepth, k.Key_Name, drawingno.drawing_no, wph.qty as HeaderQty, wph.box as box, wph.ET_powdercoat as ET_PowderCoat, "
            SQLStr = SQLStr & " wph.ET_MetalProcess as ET_MetalProcess, wph.ET_Assembly as ET_Assembly, wph.ET_Inspection as ET_Inspection, wph.ET_Completion as ET_Completion,"
            SQLStr = SQLStr & " wph.ACT_PowderCoat as ACT_PowderCoat, wph.ACT_MetalProcess as ACT_MetalProcess, wph.ACT_Assembly as ACT_Assembly, wph.ACT_Inspection as ACT_Inspection, wph.ACT_Completion as ACT_Completion "
            SQLStr = SQLStr & " FROM WorkPlanHeader wph INNER JOIN WorkPlanLine wpl ON wph.WP_ID = wpl.WP_ID AND wph.WP_ID = wpl.WP_ID INNER JOIN"
            SQLStr = SQLStr & " PartCode pc ON wpl.PartCode_ID = pc.PartCode_ID INNER JOIN"
            SQLStr = SQLStr & " Product ON wpl.Material_ID = Product.Product_ID INNER JOIN"
            SQLStr = SQLStr & " Color c ON wpl.Color_ID = c.Color_ID INNER JOIN"
            SQLStr = SQLStr & " WorkOrderHeader woh ON wph.WO_ID = woh.WO_ID INNER JOIN"
            SQLStr = SQLStr & " KeyTypes k ON wph.Key_Type = k.Key_ID inner join drawingno on drawingno.drawing_id=wph.draw_no"
            SQLStr = SQLStr & " WHERE(wph.WP_ID = " & Integer.Parse(pWP_ID) & ") ORDER BY wpl.WPLine_ID"

            With New DataAccess.DAccess.Access
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function
#End Region
    End Class

End Namespace
