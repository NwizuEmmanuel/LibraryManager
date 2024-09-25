Public Class UserID
    Private Shared _userID As Integer

    Public Shared Property UserID() As Integer
        Get
            Return _userID
        End Get
        Set(value As Integer)
            _userID = value
        End Set
    End Property
End Class
