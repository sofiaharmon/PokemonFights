Public Class Fight
    Dim char1, char2 As Character
    Dim health1, health2, RoundCount As Integer
    Dim energy1 As Integer = 10
    Dim energy2 As Integer = 10

    Public Sub New(ByRef charOne As Character, ByRef charTwo As Character)
        char1 = charOne
        char2 = charTwo
        health1 = charOne.CharHealth
        health2 = charTwo.CharHealth
    End Sub

    ReadOnly Property getChar1()
        Get
            Return char1
        End Get
    End Property

    ReadOnly Property getChar2()
        Get
            Return char2
        End Get
    End Property

    ReadOnly Property getEnergy1()
        Get
            Return energy1
        End Get
    End Property

    ReadOnly Property getEnergy2()
        Get
            Return energy2
        End Get
    End Property

    ReadOnly Property getHealth1()
        Get
            Return health1
        End Get
    End Property

    ReadOnly Property getHealth2()
        Get
            Return health2
        End Get
    End Property

    Public Property getRoundCount()
        Get
            Return RoundCount
        End Get
        Set(value)
            RoundCount = value
        End Set
    End Property

    Public Sub fight(ByVal selIndex1 As Integer, ByVal selIndex2 As Integer)
        Dim att1, att2 As Attack
        Dim effect1, effect2 As Integer

        att1 = char1.getAttacks(selIndex1)
        att2 = char2.getAttacks(selIndex2)
        effect1 = att1.getPower * char1.CharStrength * 0.2
        effect2 = att2.getPower * char2.CharStrength * 0.2

        health1 -= effect2
        health2 -= effect1

        energy1 -= char1.getAttacks(selIndex1).getEnergy
        energy2 -= char2.getAttacks(selIndex2).getEnergy

        If (health1 < 0) Then
            health1 = 0
        End If
        If (health2 < 0) Then
            health2 = 0
        End If
        If (energy1 < 0) Then
            energy1 = 0
        End If
        If (energy2 < 0) Then
            energy2 = 0
        End If
    End Sub

    Public Function IsBattleOver() As Boolean
        If (health1 <= 0 Or health2 <= 0 Or energy1 = 0 Or energy2 = 0) Then
            Return True
        End If
        Return False
    End Function

    Public Function Winner() As Integer
        If (health1 <= 0 And health2 > 0) Or (energy1 <= 0 And energy2 > 0) Then
            Return 2
        ElseIf (health2 <= 0 And health1 > 0) Or (energy2 <= 0 And energy1 > 0) Then
            Return 1
        Else Return 0
        End If
    End Function

End Class
