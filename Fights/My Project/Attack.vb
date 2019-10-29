Public Class Attack
    Dim Name As String
    Dim Power, Energy As Integer

    Public Sub New(ByVal attName As String, ByVal attPower As Integer, ByVal attEnergy As Integer)
        Name = attName
        Power = attPower
        Energy = attEnergy
    End Sub

    ReadOnly Property AttackName()
        Get
            Return Name
        End Get
    End Property
    ReadOnly Property getPower()
        Get
            Return Power
        End Get
    End Property
    ReadOnly Property getEnergy()
        Get
            Return Energy
        End Get
    End Property

End Class
