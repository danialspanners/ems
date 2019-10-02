' Business Rules Buslogic Class
' This Layer communicates between the Client GUI and the DataAccess Layer


Option Explicit On 
Option Strict On

Imports System.Data
Imports System.Data.SqlClient
Imports DataAccess.DAccess

Namespace ManProdBusRules
    Public Class ManProdBusLogic

#Region "Variables Initialization"

        'Private mvarSupplier_ID As Integer
        'Private mvarCatalog_Price As Integer
        'Private mvarEnquiry_Price As Integer
        'Private mvarPurchase_Price As Integer

        Private mvarProductID As Integer
        Private mvarName As String
        Private mvarDescription As String
        Private mvarAlt_Description As String
        'Private mvarMaterial As String
        'Private mvarColor As String
        Private mvarMaterial As Integer
        Private mvarColor As Integer
        Private mvarDimension As String
        Private mvarAlt_Dimension As String
        'Private mvarBrand As String
        Private mvarBrand As Integer
        Private mvarModel As String
        Private mvarLead_Time As String
        Private mvarGrade As String
        Private mvarUOM_ID As Integer
        Private mvarLength As Integer
        Private mvarBreadth As Integer
        Private mvarThickness As Integer

        Private mvarCategory_ID As Integer
        Private mvarKeep_Stock As String
        Private mvarStd_Part As String
        Private mvarRaw_Material As String
        Private mvarPowder_Coat As String
        Private mvarCode_Template As String
        Private mvarPole As Integer
        Private mvarFrame_Size As Integer
        Private mvarTripping_Rating As Integer
        Private mvarRapturing_Capacity As Integer
        Private mvarShunt_Trip As String
        Private mvarMech_Type As String
        Private mvarPhysical_Type As String
        Private mvarStatus As String
        '## Added by Andrew
        Private mvarLow_Alert_Qty As Integer
        Private mvarOver_Alert_Qty As Integer
        '## End
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As Integer

#End Region

#Region "Retrieve items from db - use for combo, list"

        Public Function GetUnitMeasurement(ByRef dsUOM As DataSet) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "SELECT * FROM UnitMeasurement"
                If .GetDataSet(dsUOM, SQLStr) Then
                    Return True
                End If
            End With
        End Function
        'add by alan
        Public Function GetBrand(ByRef dsBrand As DataSet, Optional ByVal pAddBlankRow As Boolean = False) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String
                SQLStr = "SELECT * FROM Brand order by Brand_name asc"
                If pAddBlankRow = True Then
                    SQLStr = "SELECT Brand_ID,Brand_Name FROM Brand union select 0 as Brand_id, '' as Brand_name order by Brand_name asc"
                End If
                If .GetDataSet(dsBrand, SQLStr) Then
                    Return True
                End If
            End With
        End Function
        Public Function GetMaterial(ByRef dsMaterial As DataSet) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "SELECT * FROM Material"
                If .GetDataSet(dsMaterial, SQLStr) Then
                    Return True
                End If
            End With
        End Function
        Public Function GetColor(ByRef dsColor As DataSet) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "SELECT * FROM Color"
                If .GetDataSet(dsColor, SQLStr) Then
                    Return True
                End If
            End With
        End Function
#End Region

#Region "Product database processes"

        Public Function Save() As Integer
            Dim strSQL As String
            Dim dsProduct As DataSet

            strSQL = "Set dateformat dmy;INSERT INTO Product("
            'strSQL = strSQL & "Name, Description, Alt_Description, Material "
            strSQL = strSQL & "Name, Description, Alt_Description, Material "
            'strSQL = strSQL & ",Color, Dimension, Alt_Dimension, Brand, Model "
            strSQL = strSQL & ",Color, Dimension, Alt_Dimension, Brand, Model "
            strSQL = strSQL & ",Lead_Time, Grade, UOM_ID, Length, Breadth "
            strSQL = strSQL & ",Thickness, Category_ID "
            strSQL = strSQL & ",Keep_Stock, Std_Part, Powder_Coat, Code_Template "
            strSQL = strSQL & ",Pole, Frame_Size, Tripping_Rating, Rapturing_Capacity, Shunt_Trip "
            '## Edited by Andrew
            strSQL = strSQL & ",Mech_Type, Physical_Type, Status, Low_Alert_Qty, Over_Alert_Qty "
            strSQL = strSQL & ", Raw_Material, Create_Date, Transact_Date, UserID "
            '## End

            strSQL = strSQL & ") VALUES("

            If Len(mvarName) > 0 Then
                strSQL = strSQL & " '" & Replace(mvarName, "'", "''") & "',"
            Else
                strSQL = strSQL & " ,"
            End If

            If Len(mvarDescription) > 0 Then
                strSQL = strSQL & " '" & Replace(mvarDescription, "'", "''") & "',"
            Else
                strSQL = strSQL & "NULL,"
            End If

            If Len(mvarAlt_Description) > 0 Then
                strSQL = strSQL & " '" & Replace(mvarAlt_Description, "'", "''") & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If

            'remove by alan
            'If Len(mvarMaterial) > 0 Then
            'strSQL = strSQL & " '" & Replace(mvarMaterial, "'", "''") & "',"
            'Else
            '    strSQL = strSQL & " NULL,"
            'End If

            'If Len(mvarColor) > 0 Then
            'strSQL = strSQL & " '" & Replace(mvarColor, "'", "''") & "',"
            'Else
            '    strSQL = strSQL & " NULL,"
            'End If

            'add by alan
            If Len(mvarMaterial) > 0 And mvarMaterial <> -1 Then
                strSQL = strSQL & mvarMaterial & ","
            Else
                strSQL = strSQL & " -1,"
            End If

            If Len(mvarColor) > 0 And mvarColor <> -1 Then
                strSQL = strSQL & mvarColor & ","
            Else
                strSQL = strSQL & " -1,"
            End If
            'end

            If Len(mvarDimension) > 0 Then
                strSQL = strSQL & " '" & Replace(mvarDimension, "'", "''") & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarAlt_Dimension) > 0 Then
                strSQL = strSQL & " '" & Replace(mvarAlt_Dimension, "'", "''") & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If
            'remove by alan
            'If Len(mvarBrand) > 0 Then
            'strSQL = strSQL & " '" & Replace(mvarBrand, "'", "''") & "',"
            'Else
            '    strSQL = strSQL & " NULL,"
            'End If

            'add by alan
            If Len(mvarBrand) > 0 And mvarBrand <> -1 Then
                strSQL = strSQL & mvarBrand & ","
            Else
                strSQL = strSQL & " -1,"
            End If
            'end

            If Len(mvarModel) > 0 Then
                strSQL = strSQL & " '" & Replace(mvarModel, "'", "''") & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarLead_Time) > 0 Then
                strSQL = strSQL & " '" & Replace(mvarLead_Time, "'", "''") & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarGrade) > 0 Then
                strSQL = strSQL & " '" & Replace(mvarGrade, "'", "''") & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarUOM_ID) > 0 And mvarUOM_ID <> -1 Then
                strSQL = strSQL & mvarUOM_ID & ","
            Else
                strSQL = strSQL & " -1,"
            End If

            If Len(mvarLength) > 0 Then
                strSQL = strSQL & " " & mvarLength & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarBreadth) > 0 Then
                strSQL = strSQL & mvarBreadth & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarThickness) > 0 Then
                strSQL = strSQL & " " & mvarThickness & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            'If Len(mvarCatalog_Price) > 0 Then
            '    strSQL = strSQL & mvarCatalog_Price & ","
            'Else
            '     strSQL = strSQL & " NULL,"
            'End If

            'If Len(mvarEnquiry_Price) > 0 Then
            '    strSQL = strSQL & mvarEnquiry_Price & ","
            'Else
            '    strSQL = strSQL & " NULL,"
            'End If

            'If Len(mvarPurchase_Price) > 0 Then
            'strSQL = strSQL & mvarPurchase_Price & ","
            'Else
            '    strSQL = strSQL & " Purchase_Price=NULL,"
            'End If

            If Len(mvarCategory_ID) > 0 Then
                strSQL = strSQL & mvarCategory_ID & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            'If Len(mvarSupplier_ID) > 0 Then
            '   strSQL = strSQL & " " & mvarSupplier_ID & ","
            'Else
            '    strSQL = strSQL & " NULL,"
            'End If

            If Len(mvarKeep_Stock) > 0 Then
                strSQL = strSQL & " '" & Replace(mvarKeep_Stock, "'", "''") & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarStd_Part) > 0 Then
                strSQL = strSQL & " '" & Replace(mvarStd_Part, "'", "''") & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarPowder_Coat) > 0 Then
                strSQL = strSQL & " '" & Replace(mvarPowder_Coat, "'", "''") & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarCode_Template) > 0 Then
                strSQL = strSQL & " '" & Replace(mvarCode_Template, "'", "''") & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarPole) > 0 And mvarPole <> -1 Then
                strSQL = strSQL & " " & mvarPole & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarFrame_Size) > 0 Then
                strSQL = strSQL & " " & mvarFrame_Size & ","
            Else
                strSQL = strSQL & "Frame_Size=NULL,"
            End If

            If Len(mvarTripping_Rating) > 0 Then
                strSQL = strSQL & " " & mvarTripping_Rating & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarRapturing_Capacity) > 0 Then
                strSQL = strSQL & " " & mvarRapturing_Capacity & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarShunt_Trip) > 0 Then
                strSQL = strSQL & " " & mvarShunt_Trip & ","
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarMech_Type) > 0 Then
                strSQL = strSQL & " '" & Replace(mvarMech_Type, "'", "''") & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarPhysical_Type) > 0 Then
                strSQL = strSQL & " '" & Replace(mvarPhysical_Type, "'", "''") & "',"
            Else
                strSQL = strSQL & " NULL,"
            End If

            If Len(mvarStatus) > 0 Then
                strSQL = strSQL & " '" & Replace(mvarStatus, "'", "''") & "', "
            Else
                strSQL = strSQL & " NULL, "
            End If

            '## Added by Andrew
            If Len(mvarLow_Alert_Qty) > 0 Then
                strSQL = strSQL & mvarLow_Alert_Qty & ", "
            Else
                strSQL = strSQL & 0 & ", "
            End If

            If Len(mvarOver_Alert_Qty) > 0 Then
                strSQL = strSQL & mvarOver_Alert_Qty & ", "
            Else
                strSQL = strSQL & 0 & ", "
            End If
            '## End

            strSQL = strSQL & "'" & mvarRaw_Material & "', "

            strSQL = strSQL & " GetDate(),"

            strSQL = strSQL & " GetDate(),"

            If Len(mvarUserID) > 0 Then
                strSQL = strSQL & mvarUserID
            Else
                strSQL = strSQL & " NULL"
            End If

            strSQL = strSQL & ")"


            strSQL = strSQL & ";(SELECT @@IDENTITY AS Product_ID from Product)"

            Debug.WriteLine(strSQL)

            With New DataAccess.DAccess.Access
                If .GetDataSet(dsProduct, strSQL) Then
                    If dsProduct.Tables(0).Rows.Count = 0 Then
                        Return Nothing
                    Else
                        Return Integer.Parse(dsProduct.Tables(0).Rows(0).Item(0).ToString)
                    End If
                Else
                    Return Nothing
                End If
            End With
            dsProduct.Dispose()

        End Function

        Public Sub Delete(ByVal pProductID As String)
            Dim strSQL As String

            strSQL = "Set dateformat dmy;DELETE FROM Product"
            strSQL = strSQL & " WHERE ProductID='" & Replace(pProductID, "'", "''") & "'"
        End Sub

        Public Sub Update(ByVal pProductID As String)

            Dim strSQL As String
            Dim dsProduct As DataSet

            strSQL = "Set dateformat dmy; Update Product set "

            If Len(mvarName) > 0 Then
                strSQL = strSQL & " Name='" & Replace(mvarName, "'", "''") & "',"
            Else
                strSQL = strSQL & " Name=NULL,"
            End If

            If Len(mvarDescription) > 0 Then
                strSQL = strSQL & " Description='" & Replace(mvarDescription, "'", "''") & "',"
            Else
                strSQL = strSQL & " Description=NULL,"
            End If

            If Len(mvarAlt_Description) > 0 Then
                strSQL = strSQL & " Alt_Description='" & Replace(mvarAlt_Description, "'", "''") & "',"
            Else
                strSQL = strSQL & " Alt_Description=NULL,"
            End If

            'remove by alan
            'If Len(mvarMaterial) > 0 Then
            'strSQL = strSQL & " Material='" & Replace(mvarMaterial, "'", "''") & "',"
            'Else
            '    strSQL = strSQL & " Material=NULL,"
            'End If

            'If Len(mvarColor) > 0 Then
            'strSQL = strSQL & " Color='" & Replace(mvarColor, "'", "''") & "',"
            'Else
            '    strSQL = strSQL & " Color=NULL,"
            'End If

            'add by alan
            If Len(mvarMaterial) > 0 And mvarMaterial <> -1 Then
                strSQL = strSQL & " Material=" & mvarMaterial & ","
            Else
                strSQL = strSQL & " Material=NULL,"
            End If

            If Len(mvarColor) > 0 And mvarColor <> -1 Then
                strSQL = strSQL & " Color=" & mvarColor & ","
            Else
                strSQL = strSQL & " Color=NULL,"
            End If
            'end

            If Len(mvarDimension) > 0 Then
                strSQL = strSQL & " Dimension='" & Replace(mvarDimension, "'", "''") & "',"
            Else
                strSQL = strSQL & " Dimension=NULL,"
            End If

            If Len(mvarAlt_Dimension) > 0 Then
                strSQL = strSQL & " Alt_Dimension='" & Replace(mvarAlt_Dimension, "'", "''") & "',"
            Else
                strSQL = strSQL & " Alt_Dimension=NULL,"
            End If

            'remove by alan
            'If Len(mvarBrand) > 0 Then
            '    strSQL = strSQL & " Brand='" & Replace(mvarBrand, "'", "''") & "',"
            'Else
            '    strSQL = strSQL & " Brand=NULL,"
            'End If

            'add by alan
            If Len(mvarBrand) > 0 And mvarBrand <> -1 Then
                strSQL = strSQL & " Brand=" & mvarBrand & ","
            Else
                strSQL = strSQL & " Brand=NULL,"
            End If
            'end

            If Len(mvarModel) > 0 Then
                strSQL = strSQL & " Model='" & Replace(mvarModel, "'", "''") & "',"
            Else
                strSQL = strSQL & " Model=NULL,"
            End If

            If Len(mvarLead_Time) > 0 Then
                strSQL = strSQL & " Lead_Time='" & Replace(mvarLead_Time, "'", "''") & "',"
            Else
                strSQL = strSQL & " Lead_Time=NULL,"
            End If

            If Len(mvarGrade) > 0 Then
                strSQL = strSQL & " Grade='" & Replace(mvarGrade, "'", "''") & "',"
            Else
                strSQL = strSQL & " Grade=NULL,"
            End If

            If Len(mvarUOM_ID) > 0 And mvarUOM_ID <> -1 Then
                strSQL = strSQL & " UOM_ID=" & mvarUOM_ID & ","
            Else
                strSQL = strSQL & " UOM_ID=NULL,"
            End If

            If Len(mvarLength) > 0 Then
                strSQL = strSQL & " Length=" & mvarLength & ","
            Else
                strSQL = strSQL & " Length=NULL,"
            End If

            If Len(mvarBreadth) > 0 Then
                strSQL = strSQL & " Breadth=" & mvarBreadth & ","
            Else
                strSQL = strSQL & " Breadth=NULL,"
            End If

            If Len(mvarThickness) > 0 Then
                strSQL = strSQL & " Thickness=" & mvarThickness & ","
            Else
                strSQL = strSQL & " Thickness=NULL,"
            End If

            'If Len(mvarCatalog_Price) > 0 Then
            '    strSQL = strSQL & " Catalog_Price=" & mvarCatalog_Price & ","
            'Else
            '    strSQL = strSQL & " Catalog_Price=NULL,"
            'End If

            'If Len(mvarEnquiry_Price) > 0 Then
            '   strSQL = strSQL & " Enquiry_Price=" & mvarEnquiry_Price & ","
            'Else
            '    strSQL = strSQL & " Enquiry_Price=NULL,"
            'End If

            'If Len(mvarPurchase_Price) > 0 Then
            '    strSQL = strSQL & " Purchase_Price=" & mvarPurchase_Price & ","
            'Else
            '    strSQL = strSQL & " Purchase_Price=NULL,"
            'End If

            If Len(mvarCategory_ID) > 0 Then
                strSQL = strSQL & " Category_ID=" & mvarCategory_ID & ","
            Else
                strSQL = strSQL & " Category_ID=NULL,"
            End If

            'If Len(mvarSupplier_ID) > 0 Then
            '    strSQL = strSQL & " Supplier_ID=" & mvarSupplier_ID & ","
            'Else
            '    strSQL = strSQL & " Supplier_ID=NULL,"
            ' End If

            If Len(mvarKeep_Stock) > 0 Then
                strSQL = strSQL & " Keep_Stock='" & Replace(mvarKeep_Stock, "'", "''") & "',"
            Else
                strSQL = strSQL & " Keep_Stock=NULL,"
            End If

            If Len(mvarStd_Part) > 0 Then
                strSQL = strSQL & " Std_Part='" & Replace(mvarStd_Part, "'", "''") & "',"
            Else
                strSQL = strSQL & " Std_Part=NULL,"
            End If

            If Len(mvarPowder_Coat) > 0 Then
                strSQL = strSQL & " Powder_Coat='" & Replace(mvarPowder_Coat, "'", "''") & "',"
            Else
                strSQL = strSQL & " Powder_Coat=NULL,"
            End If

            If Len(mvarCode_Template) > 0 Then
                strSQL = strSQL & " Code_Template='" & Replace(mvarCode_Template, "'", "''") & "',"
            Else
                strSQL = strSQL & " Code_Template=NULL,"
            End If

            If Len(mvarPole) > 0 And mvarPole <> -1 Then
                strSQL = strSQL & " Pole=" & mvarPole & ","
            Else
                strSQL = strSQL & " Pole=NULL,"
            End If

            If Len(mvarFrame_Size) > 0 Then
                strSQL = strSQL & " Frame_Size=" & mvarFrame_Size & ","
            Else
                strSQL = strSQL & " Frame_Size=NULL,"
            End If

            If Len(mvarTripping_Rating) > 0 Then
                strSQL = strSQL & " Tripping_Rating=" & mvarTripping_Rating & ","
            Else
                strSQL = strSQL & " Tripping_Rating=NULL,"
            End If

            If Len(mvarRapturing_Capacity) > 0 Then
                strSQL = strSQL & " Rapturing_Capacity=" & mvarRapturing_Capacity & ","
            Else
                strSQL = strSQL & " Rapturing_Capacity=NULL,"
            End If

            If Len(mvarShunt_Trip) > 0 Then
                strSQL = strSQL & " Shunt_Trip=" & mvarShunt_Trip & ","
            Else
                strSQL = strSQL & " Shunt_Trip=NULL,"
            End If

            If Len(mvarMech_Type) > 0 Then
                strSQL = strSQL & " Mech_Type='" & Replace(mvarMech_Type, "'", "''") & "',"
            Else
                strSQL = strSQL & " Mech_Type=NULL,"
            End If

            If Len(mvarPhysical_Type) > 0 Then
                strSQL = strSQL & " Physical_Type='" & Replace(mvarPhysical_Type, "'", "''") & "',"
            Else
                strSQL = strSQL & " Physical_Type=NULL,"
            End If

            If Len(mvarStatus) > 0 Then
                strSQL = strSQL & " Status='" & Replace(mvarStatus, "'", "''") & "',"
            Else
                strSQL = strSQL & " Status=NULL,"
            End If

            '## Added by Andrew
            If Len(mvarLow_Alert_Qty) > 0 Then
                strSQL = strSQL & " Low_Alert_Qty=" & mvarLow_Alert_Qty & ","
            Else
                strSQL = strSQL & " Low_Alert_Qty=0,"
            End If

            If Len(mvarOver_Alert_Qty) > 0 Then
                strSQL = strSQL & " Over_Alert_Qty=" & mvarOver_Alert_Qty & ","
            Else
                strSQL = strSQL & " Over_Alert_Qty=0,"
            End If
            '## End

            If Len(mvarRaw_Material) > 0 Then
                strSQL = strSQL & " Raw_Material='" & mvarRaw_Material & "',"
            End If

            strSQL = strSQL & " Transact_Date=GetDate(),"

            If Len(mvarUserID) > 0 Then
                strSQL = strSQL & " UserID=" & mvarUserID
            Else
                strSQL = strSQL & " UserID=NULL"
            End If

            strSQL = strSQL & " WHERE Product_ID = " & pProductID

            Debug.WriteLine(strSQL)

            With New DataAccess.DAccess.Access
                If .GetDataSet(dsProduct, strSQL) Then

                End If
            End With
            dsProduct.Dispose()

        End Sub

        Public Function LoadList(ByRef dsCategory As DataSet, Optional ByVal pCategory_ID As String = "") As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "SELECT * FROM Product"

                If pCategory_ID <> "" Then
                    SQLStr = SQLStr & " WHERE Category_ID =" & pCategory_ID
                End If


                If .GetDataSet(dsCategory, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function LoadList_StdProduct(ByRef dsCategory As DataSet) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "SELECT * FROM Product"

                SQLStr = SQLStr & " WHERE Category_ID =27" 'finished goods 
                SQLStr = SQLStr & " and Std_Part =1" 'standard part

                If .GetDataSet(dsCategory, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function Load(ByRef dsProduct As DataSet, ByVal ProductName As String, ByVal Brand As String, ByVal Desc As String, ByVal Desc2 As String, ByVal Model As String, ByVal CatID As Integer) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "SELECT *,Category.Name as Category FROM Product"
                SQLStr = SQLStr & " left join Category on (Product.Category_ID=Category.Category_ID)"
                SQLStr = SQLStr & " left join UnitMeasurement on (Product.UOM_ID=UnitMeasurement.UOM_ID)"
                SQLStr = SQLStr & " left join Materials on (Product.Material=Materials.Material_ID)"
                SQLStr = SQLStr & " left join Color on (Product.Color=Color.Color_ID)"

                SQLStr = SQLStr & " left join Brand on (Brand.Brand_ID=Product.Brand) where (1=1) "
                If ProductName <> "" Then
                    SQLStr = SQLStr & "and Product.Name Like '" & ProductName & "%' "
                End If
                If Brand <> "" Then
                    SQLStr = SQLStr & "and Brand.Brand_Name like '" & Brand & "%' "
                End If
                If Desc <> "" Then
                    SQLStr = SQLStr & "and Product.Description like '%" & Desc & "%' "
                End If
                If Desc2 <> "" Then
                    SQLStr = SQLStr & "and Product.Alt_Description like '%" & Desc2 & "%' "
                End If
                If Model <> "" Then
                    SQLStr = SQLStr & "and Product.Model like '%" & Model & "%' "
                End If

                If CatID <> 0 Then
                    SQLStr = SQLStr & "and Category.Category_ID = " & CatID
                End If

                SQLStr = SQLStr & " order by Product.Name asc "
                'SELECT     *
                'FROM         Brand, Product where Brand.Brand_ID = Product.Brand
                'and product.name like 'A%' and Brand.Brand_Name like 'M%'
                If .GetDataSet(dsProduct, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function Load(ByRef dsProduct As DataSet, Optional ByVal ProductName As String = "") As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "SELECT * FROM Product"
                'If ProductID <> "" Then
                'SQLStr = SQLStr & " WHERE Name ='" & ProductName & "'"
                SQLStr = SQLStr & " WHERE Name Like '" & ProductName & "%'"
                'End If

                If .GetDataSet(dsProduct, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function Load(Optional ByVal pProduct_ID As String = "") As Boolean
            With New DataAccess.DAccess.Access
                Dim ds As DataSet
                Dim SQLStr As String = "SELECT * FROM Product"

                If pProduct_ID <> "" Then
                    SQLStr = SQLStr & " WHERE Product_ID =" & pProduct_ID
                End If

                SQLStr = SQLStr & " Order by Product.Name Asc"

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

                    If Not row.IsNull("Alt_Description") Then
                        Alt_Description = row("Alt_Description").ToString()
                    Else
                        Alt_Description = ""
                    End If

                    'remove by alan
                    'If Not row.IsNull("Material") Then
                    'Material = row("Material").ToString()
                    'Else
                    'Material = ""
                    'End If

                    'If Not row.IsNull("Color") Then
                    'Color = row("Color").ToString()
                    'Else
                    'Color = ""
                    'End If

                    'add by alan
                    If Not row.IsNull("Material") Then
                        Material = [Integer].Parse(row("Material").ToString())
                    Else
                        Material = -1
                    End If

                    If Not row.IsNull("Color") Then
                        Color = [Integer].Parse(row("Color").ToString())
                    Else
                        Color = -1
                    End If
                    'end

                    If Not row.IsNull("Dimension") Then
                        Dimension = row("Dimension").ToString()
                    Else
                        Dimension = ""
                    End If

                    If Not row.IsNull("Alt_Dimension") Then
                        Alt_Dimension = row("Alt_Dimension").ToString()
                    Else
                        Alt_Dimension = ""
                    End If

                    'remove by alan
                    'If Not row.IsNull("Brand") Then
                    '    Brand = row("Brand").ToString()
                    'Else
                    '    Brand = ""
                    'End If

                    'add by alan
                    If Not row.IsNull("Brand") Then
                        Brand = [Integer].Parse(row("Brand").ToString())
                    Else
                        Brand = -1
                    End If
                    'end

                    If Not row.IsNull("Model") Then
                        Model = row("Model").ToString()
                    Else
                        Model = ""
                    End If

                    If Not row.IsNull("Lead_Time") Then
                        Lead_Time = row("Lead_Time").ToString()
                    Else
                        Lead_Time = "NA"
                    End If

                    If Not row.IsNull("Grade") Then
                        Grade = row("Grade").ToString()
                    Else
                        Grade = ""
                    End If

                    If Not row.IsNull("UOM_ID") Then
                        UOM_ID = [Integer].Parse(row("UOM_ID").ToString())
                    Else
                        UOM_ID = -1
                    End If

                    If Not row.IsNull("Length") Then
                        Length = [Integer].Parse(row("Length").ToString())
                    Else
                        Length = Nothing
                    End If

                    If Not row.IsNull("Breadth") Then
                        Breadth = [Integer].Parse(row("Breadth").ToString())
                    Else
                        Breadth = Nothing
                    End If

                    If Not row.IsNull("Thickness") Then
                        Thickness = [Integer].Parse(row("Thickness").ToString())
                    Else
                        Thickness = Nothing
                    End If

                    'If Not row.IsNull("Catalog_Price") Then
                    '    Catalog_Price = [Integer].Parse(row("Catalog_Price").ToString())
                    'Else
                    '   Catalog_Price = Nothing
                    'End If

                    'If Not row.IsNull("Enquiry_Price") Then
                    '    Enquiry_Price = [Integer].Parse(row("Enquiry_Price").ToString())
                    'Else
                    '    Enquiry_Price = Nothing
                    'End If

                    'If Not row.IsNull("Purchase_Price") Then
                    '    Purchase_Price = [Integer].Parse(row("Purchase_Price").ToString())
                    'Else
                    '    Purchase_Price = Nothing
                    'End If

                    If Not row.IsNull("Category_ID") Then
                        Category_ID = [Integer].Parse(row("Category_ID").ToString())
                    Else
                        Category_ID = Nothing
                    End If

                    'If Not row.IsNull("Supplier_ID") Then
                    '    Supplier_ID = [Integer].Parse(row("Supplier_ID").ToString())
                    'Else
                    '    Supplier_ID = Nothing
                    'End If

                    If Not row.IsNull("Keep_Stock") Then
                        Keep_Stock = row("Keep_Stock").ToString()
                    Else
                        Keep_Stock = ""
                    End If

                    If Not row.IsNull("Std_Part") Then
                        Std_Part = row("Std_Part").ToString()
                    Else
                        Std_Part = ""
                    End If

                    If Not row.IsNull("Powder_Coat") Then
                        Powder_Coat = row("Powder_Coat").ToString()
                    Else
                        Powder_Coat = ""
                    End If

                    Raw_Material = ds.Tables(0).Rows(0)("Raw_Material").ToString()

                    If Not row.IsNull("Code_Template") Then
                        Code_Template = row("Code_Template").ToString()
                    Else
                        Code_Template = ""
                    End If

                    If Not row.IsNull("Pole") Then
                        Pole = [Integer].Parse(row("Pole").ToString())
                    Else
                        Pole = Nothing
                    End If

                    If Not row.IsNull("Frame_Size") Then
                        Frame_Size = [Integer].Parse(row("Frame_Size").ToString())
                    Else
                        Frame_Size = Nothing
                    End If

                    If Not row.IsNull("Tripping_Rating") Then
                        Tripping_Rating = [Integer].Parse(row("Tripping_Rating").ToString())
                    Else
                        Tripping_Rating = Nothing
                    End If

                    If Not row.IsNull("Rapturing_Capacity") Then
                        Rapturing_Capacity = [Integer].Parse(row("Rapturing_Capacity").ToString())
                    Else
                        Rapturing_Capacity = Nothing
                    End If

                    If Not row.IsNull("Shunt_Trip") Then
                        Shunt_Trip = row("Shunt_Trip").ToString()
                    Else
                        Shunt_Trip = ""
                    End If

                    If Not row.IsNull("Mech_Type") Then
                        Mech_Type = row("Mech_Type").ToString()
                    Else
                        Mech_Type = ""
                    End If

                    If Not row.IsNull("Physical_Type") Then
                        Physical_Type = row("Physical_Type").ToString()
                    Else
                        Physical_Type = ""
                    End If

                    If Not row.IsNull("Status") Then
                        Status = row("Status").ToString()
                    Else
                        Status = ""
                    End If

                    '## Added by Andrew
                    If Not row.IsNull("Low_Alert_Qty") Then
                        Low_Alert_Qty = [Integer].Parse(row("Low_Alert_Qty").ToString())
                    Else
                        Low_Alert_Qty = Nothing
                    End If

                    If Not row.IsNull("Over_Alert_Qty") Then
                        Over_Alert_Qty = [Integer].Parse(row("Over_Alert_Qty").ToString())
                    Else
                        Over_Alert_Qty = Nothing
                    End If
                    '## End

                    Return True
                End If
            End With
        End Function

        'Check for unique name
        Public Function RecordExists(ByVal pName As String, Optional ByVal pProduct_ID As String = "") As Boolean

            Dim SQLStr As String
            Dim ds As DataSet

            SQLStr = "SELECT * FROM Product"
            SQLStr = SQLStr & " WHERE Name='" & Replace(pName, "'", "''") & "'"

            If pProduct_ID <> "" Then
                SQLStr = SQLStr & " AND Product_ID<>'" & pProduct_ID & "'"
            End If

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

        Public Property ProductID() As Integer
            Get
                Return mvarProductID
            End Get
            Set(ByVal Value As Integer)
                mvarProductID = Value
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

        Public Property Alt_Description() As String
            Get
                Return mvarAlt_Description
            End Get
            Set(ByVal Value As String)
                mvarAlt_Description = Value
            End Set
        End Property

        'remove by alan
        'Public Property Material() As String
        '    Get
        '        Return mvarMaterial
        '    End Get
        '    Set(ByVal Value As String)
        '        mvarMaterial = Value
        '    End Set
        'End Property

        'Public Property Color() As String
        '    Get
        '        Return mvarColor
        '    End Get
        '    Set(ByVal Value As String)
        '        mvarColor = Value
        '    End Set
        'End Property
        'end 

        'add by alan
        Public Property Material() As Integer
            Get
                Return mvarMaterial
            End Get
            Set(ByVal Value As Integer)
                mvarMaterial = Value
            End Set
        End Property
        Public Property Color() As Integer
            Get
                Return mvarColor
            End Get
            Set(ByVal Value As Integer)
                mvarColor = Value
            End Set
        End Property
        'end

        Public Property Dimension() As String
            Get
                Return mvarDimension
            End Get
            Set(ByVal Value As String)
                mvarDimension = Value
            End Set
        End Property

        Public Property Alt_Dimension() As String
            Get
                Return mvarAlt_Dimension
            End Get
            Set(ByVal Value As String)
                mvarAlt_Dimension = Value
            End Set
        End Property
        'remove by alan
        'Public Property Brand() As String
        'Get
        'Return mvarBrand
        'End Get
        'Set(ByVal Value As String)
        'mvarBrand = Value
        'End Set
        'End Property

        'add by alan
        Public Property Brand() As Integer
            Get
                Return mvarBrand
            End Get
            Set(ByVal Value As Integer)
                mvarBrand = Value
            End Set
        End Property


        Public Property Model() As String
            Get
                Return mvarModel
            End Get
            Set(ByVal Value As String)
                mvarModel = Value
            End Set
        End Property

        Public Property Lead_Time() As String
            Get
                Return mvarLead_Time
            End Get
            Set(ByVal Value As String)
                mvarLead_Time = Value
            End Set
        End Property

        Public Property Grade() As String
            Get
                Return mvarGrade
            End Get
            Set(ByVal Value As String)
                mvarGrade = Value
            End Set
        End Property

        Public Property UOM_ID() As Integer
            Get
                Return mvarUOM_ID
            End Get
            Set(ByVal Value As Integer)
                mvarUOM_ID = Value
            End Set
        End Property

        Public Property Length() As Integer
            Get
                Return mvarLength
            End Get
            Set(ByVal Value As Integer)
                mvarLength = Value
            End Set
        End Property

        Public Property Breadth() As Integer
            Get
                Return mvarBreadth
            End Get
            Set(ByVal Value As Integer)
                mvarBreadth = Value
            End Set
        End Property

        Public Property Thickness() As Integer
            Get
                Return mvarThickness
            End Get
            Set(ByVal Value As Integer)
                mvarThickness = Value
            End Set
        End Property

        'Public Property Catalog_Price() As Integer
        '   Get
        '      Return mvarCatalog_Price
        '   End Get
        '   Set(ByVal Value As Integer)
        '       mvarCatalog_Price = Value
        '   End Set
        'End Property

        'Public Property Enquiry_Price() As Integer
        '   Get
        '       Return mvarEnquiry_Price
        '    End Get
        '   Set(ByVal Value As Integer)
        '       mvarEnquiry_Price = Value
        '  End Set
        'End Property

        'Public Property Purchase_Price() As Integer
        '    Get
        '        Return mvarPurchase_Price
        '    End Get
        '    Set(ByVal Value As Integer)
        '        mvarPurchase_Price = Value
        '    End Set
        'End Property

        Public Property Category_ID() As Integer
            Get
                Return mvarCategory_ID
            End Get
            Set(ByVal Value As Integer)
                mvarCategory_ID = Value
            End Set
        End Property

        'Public Property Supplier_ID() As Integer
        '     Get
        '        Return mvarSupplier_ID
        '    End Get
        '    Set(ByVal Value As Integer)
        '        mvarSupplier_ID = Value
        '    End Set
        ' End Property

        Public Property Keep_Stock() As String
            Get
                Return mvarKeep_Stock
            End Get
            Set(ByVal Value As String)
                mvarKeep_Stock = Value
            End Set
        End Property

        Public Property Std_Part() As String
            Get
                Return mvarStd_Part
            End Get
            Set(ByVal Value As String)
                mvarStd_Part = Value
            End Set
        End Property

        Public Property Raw_Material() As String
            Get
                Return mvarRaw_Material
            End Get
            Set(ByVal Value As String)
                mvarRaw_Material = Value
            End Set
        End Property

        Public Property Powder_Coat() As String
            Get
                Return mvarPowder_Coat
            End Get
            Set(ByVal Value As String)
                mvarPowder_Coat = Value
            End Set
        End Property

        Public Property Code_Template() As String
            Get
                Return mvarCode_Template
            End Get
            Set(ByVal Value As String)
                mvarCode_Template = Value
            End Set
        End Property

        Public Property Pole() As Integer
            Get
                Return mvarPole
            End Get
            Set(ByVal Value As Integer)
                mvarPole = Value
            End Set
        End Property

        Public Property Frame_Size() As Integer
            Get
                Return mvarFrame_Size
            End Get
            Set(ByVal Value As Integer)
                mvarFrame_Size = Value
            End Set
        End Property

        Public Property Tripping_Rating() As Integer
            Get
                Return mvarTripping_Rating
            End Get
            Set(ByVal Value As Integer)
                mvarTripping_Rating = Value
            End Set
        End Property

        Public Property Rapturing_Capacity() As Integer
            Get
                Return mvarRapturing_Capacity
            End Get
            Set(ByVal Value As Integer)
                mvarRapturing_Capacity = Value
            End Set
        End Property

        Public Property Shunt_Trip() As String
            Get
                Return mvarShunt_Trip
            End Get
            Set(ByVal Value As String)
                mvarShunt_Trip = Value
            End Set
        End Property

        Public Property Mech_Type() As String
            Get
                Return mvarMech_Type
            End Get
            Set(ByVal Value As String)
                mvarMech_Type = Value
            End Set
        End Property

        Public Property Physical_Type() As String
            Get
                Return mvarPhysical_Type
            End Get
            Set(ByVal Value As String)
                mvarPhysical_Type = Value
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
        '## Added by Andrew
        Public Property Low_Alert_Qty() As Integer
            Get
                Return mvarLow_Alert_Qty
            End Get
            Set(ByVal Value As Integer)
                mvarLow_Alert_Qty = Value
            End Set
        End Property

        Public Property Over_Alert_Qty() As Integer
            Get
                Return mvarOver_Alert_Qty
            End Get
            Set(ByVal Value As Integer)
                mvarOver_Alert_Qty = Value
            End Set
        End Property
        '## End
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
