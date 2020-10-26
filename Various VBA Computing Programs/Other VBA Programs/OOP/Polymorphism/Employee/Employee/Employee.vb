Public Class Employee
    'This is an example of Polymorphism
    Private ESurname As String
    Private EForename As String
    Private EType As String
    Public Property Surname() As String
        Get
            Return ESurname
        End Get
        Set(ByVal value As String)
            ESurname = value
        End Set
    End Property
    Public Property Forename() As String
        Get
            Return EForename
        End Get
        Set(ByVal value As String)
            EForename = value
        End Set
    End Property
    Public Property Type() As String
        Get
            Return EType
        End Get
        Set(ByVal value As String)
            EType = value
        End Set
    End Property
    Overridable Function Pay(ByVal Hours As Integer) As Single
        Return Hours * 5.7
    End Function
End Class
Public Class Junior
    Inherits Employee
    Private JGuardian As String
    Public Property Guardian() As String
        Get
            Return JGuardian
        End Get
        Set(ByVal value As String)
            JGuardian = value
        End Set
    End Property
    Public Overrides Function Pay(ByVal Hours As Integer) As Single
        Return Hours * 4.78
    End Function
End Class
