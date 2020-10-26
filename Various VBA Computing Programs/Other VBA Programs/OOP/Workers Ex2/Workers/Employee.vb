Public Class Employee
    Private EmpID As String
    Private EmpName As String
    Private EmpRate As Single
    Private EmpHours As Integer
    Private EmpWage As Single
    Private EmpTax As Single
    Public Property ID()
        Get
            Return EmpID
        End Get
        Set(ByVal value)
            EmpID = value
        End Set
    End Property
    Public Property Name()
        Get
            Return EmpName
        End Get
        Set(ByVal value)
            EmpName = value
        End Set
    End Property
    Public Property Rate()
        Get
            Return EmpRate
        End Get
        Set(ByVal value)
            EmpRate = value
        End Set
    End Property
    Public Property Hours()
        Get
            Return EmpHours
        End Get
        Set(ByVal value)
            EmpHours = value
        End Set
    End Property
    Public Property Wage()
        Get
            Return EmpWage
        End Get
        Set(ByVal value)
            EmpWage = value
        End Set
    End Property
    Public Property Tax()
        Get
            Return EmpTax
        End Get
        Set(ByVal value)
            EmpTax = value
        End Set
    End Property
    Public Sub WKInitialise(ByVal EID As String, ByVal EName As String, ByVal ERate As Single)
        EmpID = EID
        EmpName = EName
        EmpRate = ERate
        EmpHours = 0
        EmpWage = 0
    End Sub
    Public Sub WKCalWage(ByVal CHours As Single)
        EmpHours = CHours
        EmpWage = EmpRate * EmpHours
    End Sub
    Public Sub WKPayRise(ByVal PRate As Single)
        EmpRate = PRate
    End Sub
    Public Sub WKTax(ByVal TaxRate As Single)
        EmpTax = EmpWage * TaxRate
    End Sub
End Class


