Imports System.Data.OleDb

Public Class ExcelTools

    Public Function Export(ByVal GridView2 As DevExpress.XtraGrid.Views.Grid.GridView) As Boolean

        If ((GridView2.Columns.Count = 0) Or (GridView2.RowCount = 0)) Then
            Exit Function
        End If

        'Creating dataset to export
        Dim dset As New DataSet
        'add table to dataset
        dset.Tables.Add()
        'add column to that table
        For i As Integer = 0 To GridView2.Columns.Count - 1
            If GridView2.Columns.Item(i).VisibleIndex <> -1 Then
                dset.Tables(0).Columns.Add(GridView2.Columns(i).Caption)
            End If
        Next
        'add rows to the table
        Dim dr1 As DataRow
        For i As Integer = 0 To GridView2.RowCount - 1
            dr1 = dset.Tables(0).NewRow
            For j As Integer = 0 To GridView2.Columns.Count - 1
                If GridView2.Columns.Item(j).VisibleIndex <> -1 Then
                    dr1(GridView2.Columns.Item(j).VisibleIndex) = GridView2.GetDataRow(i)(j)
                End If
            Next
            dset.Tables(0).Rows.Add(dr1)
        Next

        Dim excel As New Microsoft.Office.Interop.Excel.ApplicationClass
        Dim wBook As Microsoft.Office.Interop.Excel.Workbook
        Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet

        wBook = excel.Workbooks.Add()
        wSheet = wBook.ActiveSheet()

        Dim dt As System.Data.DataTable = dset.Tables(0)
        Dim dc As System.Data.DataColumn
        Dim dr As System.Data.DataRow
        Dim colIndex As Integer = 0
        Dim rowIndex As Integer = 0

        For Each dc In dt.Columns
            colIndex = colIndex + 1
            excel.Cells(1, colIndex) = dc.ColumnName
        Next

        For Each dr In dt.Rows
            rowIndex = rowIndex + 1
            colIndex = 0
            For Each dc In dt.Columns
                colIndex = colIndex + 1
                excel.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)

            Next
        Next

        wSheet.Columns.AutoFit()
        Dim strFileName As String = "D:\ss.xls"
        Dim blnFileOpen As Boolean = False
        Try
            Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(strFileName)
            fileTemp.Close()
        Catch ex As Exception
            blnFileOpen = False
        End Try

        If System.IO.File.Exists(strFileName) Then
            System.IO.File.Delete(strFileName)
        End If

        wBook.SaveAs(strFileName)
        excel.Workbooks.Open(strFileName)
        excel.Visible = True

    End Function



    Public Function Export(ByVal ds As DataSet, ByVal pFilename As String) As Boolean

        Dim excel As New Microsoft.Office.Interop.Excel.ApplicationClass
        Dim wBook As Microsoft.Office.Interop.Excel.Workbook
        Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet

        wBook = excel.Workbooks.Add()
        wSheet = wBook.ActiveSheet()

        Dim dt As System.Data.DataTable = ds.Tables(0) 'dset.Tables(0)
        Dim dc As System.Data.DataColumn
        Dim dr As System.Data.DataRow
        Dim colIndex As Integer = 0
        Dim rowIndex As Integer = 0

        For Each dc In dt.Columns
            colIndex = colIndex + 1
            excel.Cells(1, colIndex) = dc.Caption
        Next

        For Each dr In dt.Rows
            rowIndex = rowIndex + 1
            colIndex = 0
            For Each dc In dt.Columns
                colIndex = colIndex + 1
                excel.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
            Next
        Next

        wSheet.Columns.AutoFit()
        Dim strFileName As String = pFilename
        Dim blnFileOpen As Boolean = False
        Try
            Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(strFileName)
            fileTemp.Close()
        Catch ex As Exception
            blnFileOpen = False
        End Try

        If System.IO.File.Exists(strFileName) Then
            System.IO.File.Delete(strFileName)
        End If

        wBook.SaveAs(strFileName)
        'excel.Workbooks.Open(strFileName)
        'excel.Visible = True
        excel.Quit()
        wSheet = Nothing
        wBook = Nothing
        excel = Nothing

        If System.IO.File.Exists(strFileName) Then
            Return True
        Else
            Return False
        End If


    End Function

    Dim oleconn As OleDbConnection

    Function OpenExcel(ByVal pfilename As String, Optional ByVal pFirstrowheader As Boolean = True) As Boolean

        Dim hdrno As String

        If pFirstrowheader = True Then
            hdrno = ""
        Else
            hdrno = "HDRNO=NO"
        End If


        Dim connstr = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
     "Data Source=" & pfilename & "; Jet OLEDB:Engine Type=5;" & _
     "Extended Properties=""Excel 8.0;" & hdrno & """ "

        If oleconn.State <> ConnectionState.Closed Then
            oleconn.Close()
            oleconn.Dispose()
        End If

        oleconn = New OleDbConnection(connstr)

    End Function

    Function LoadSchema() As Array

        If oleconn.State <> ConnectionState.Closed Then
            Return Nothing
        End If

        Dim SchemaTable As DataTable
        Dim tmprow As DataRow

        SchemaTable = oleconn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)

        If SchemaTable.Rows.Count > 0 Then

            For Each tmprow In SchemaTable.Rows

            Next

        End If


        Return Nothing

    End Function



End Class
