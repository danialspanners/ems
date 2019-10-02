
Namespace CurrencyBusRules

    Public Class CurrencyBusLogic

#Region "Variables Initialization"

        Private mvarCurrency_ID As Integer
        Private mvarCurrencyName As String
        Private mvarCurrencySymbol As String
        Private mvarCreate_Date As String
        Private mvarTransact_Date As String
        Private mvarUserID As Integer

#End Region

        Public Function LoadList(ByRef ds As DataSet) As Boolean
            With New DataAccess.DAccess.Access

                Dim SQLStr As String = "SELECT * FROM Currency"
                If .GetDataSet(ds, SQLStr) Then
                    Return True
                End If
            End With
        End Function

        Public Function Load(Optional ByVal pCurrency_ID As String = "") As Boolean
            With New DataAccess.DAccess.Access
                Dim ds As DataSet
                Dim SQLStr As String = "SELECT * FROM Currency"

                If pCurrency_ID <> "" Then
                    SQLStr = SQLStr & " WHERE Currency_ID =" & pCurrency_ID
                End If

                If .GetDataSet(ds, SQLStr) Then
                    If ds.Tables(0).Rows.Count > 0 Then

                        Dim row As DataRow = ds.Tables(0).Rows(0)

                        If Not row.IsNull("CurrencyName") Then
                            CurrencyName = row("CurrencyName").ToString()
                        Else
                            CurrencyName = ""
                        End If
                        If Not row.IsNull("CurrencySymbol") Then
                            CurrencySymbol = row("CurrencySymbol").ToString()
                        Else
                            CurrencySymbol = ""
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
                End If
            End With
        End Function

#Region "Get and Let Property"

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

End Namespace
