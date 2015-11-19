Public Class players


    Private name As String
    Public Property playerName() As String
        Get
            Return name
        End Get
        Set(ByVal value As String)
            name = value
        End Set
    End Property

    Private score As Integer
    Public Property playerScore() As Integer
        Get
            Return score
        End Get
        Set(ByVal value As Integer)
            score = value
        End Set
    End Property

    Private nameAndScore As String
    Public Property nameScore() As String
        Get
            Return nameAndScore
        End Get
        Set(ByVal value As String)
            nameAndScore = value
        End Set
    End Property

End Class

