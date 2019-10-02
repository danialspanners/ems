Imports Microsoft.Data.Odbc

Public Class testForm

    Private Sub testForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ConnectionString As String

        ConnectionString = "Driver={MYOSG0801}; Type=MYOB; UID=Administrator; PWD=;" & _
        "DATABASE=C:\PREMIER12\Clearwtr.myo;" & _
        "HOST_EXE_PATH=c:\premier12\myob.exe;" & _
        "Access_type=READ_WRITE;" & _
        "NETWORK_PROTOCOL=NONET;" & _
        "DRIVER_COMPLETION=DRIVER_NOPROMPT;"

        Dim Connectionstring2 As String
        Connectionstring2 = "DSN=MYOBTesting125;ACCESS_TYPE=READ_WRITE;"

        Dim Dconn As OdbcConnection
        Dim cmd As OdbcCommand
        Dconn = New OdbcConnection(Connectionstring2)
        Dconn.Open()
        cmd = New OdbcCommand("", Dconn)
        Try

            cmd.CommandText = "Insert into Import_Customer_Cards (CoLastName) values ('Test123') "
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
        Dconn.Close()

    End Sub
End Class