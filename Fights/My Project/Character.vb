Public Class Character
    Dim Name, picName As String
    Dim Health, Strength As Integer
    Dim AttackList As New List(Of Attack)

    'image name!!

    Public Sub New(ByVal charName As String, ByVal charPic As String, ByVal charHealth As Integer, ByVal charStrength As Integer, ByVal attacks As List(Of Attack))
        Name = charName
        picName = charPic
        Health = charHealth
        Strength = charStrength
        AttackList = attacks
    End Sub

    ReadOnly Property CharName() As String
        Get
            Return Name
        End Get
    End Property

    ReadOnly Property getPicName() As String
        Get
            Return picName
        End Get
    End Property

    ReadOnly Property CharHealth() As Integer
        Get
            Return Health
        End Get
    End Property

    ReadOnly Property CharStrength() As Integer
        Get
            Return Strength
        End Get
    End Property

    ReadOnly Property getAttacks() As List(Of Attack)
        Get
            Return AttackList
        End Get
    End Property

End Class
