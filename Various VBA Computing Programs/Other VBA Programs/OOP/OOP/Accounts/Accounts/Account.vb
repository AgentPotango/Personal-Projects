Public Class Account
    Private AccSurname As String
    Private AccForename As String
    Private AccNo As String
    Private AccBal As Integer
    Public Property Surname() As String
        Get
            Return AccSurname
        End Get
        Set(ByVal value As String)
            AccSurname = value
        End Set
    End Property
    Public Property Forename() As String
        Get
            Return AccForename
        End Get
        Set(ByVal value As String)
            AccForename = value
        End Set
    End Property
    Public Property Account() As String
        Get
            Return AccNo
        End Get
        Set(ByVal value As String)
            AccNo = value
        End Set
    End Property
    Public Property Balance()
        Get
            Return AccBal
        End Get
        Set(ByVal value)
            AccBal = value
        End Set
    End Property
    Public Sub OpenAccount(ByVal ANo As String, ByVal AForename As String, ByVal ASurname As String)
        AccSurname = ASurname
        AccForename = AForename
        AccNo = ANo
        AccBal = 0
    End Sub
    Public Sub AmendBalance(ByVal TValue As Single)
        AccBal = AccBal + TValue
    End Sub
End Class


