Public Class BookID
    Private Shared _bookID As Integer

    Public Shared Property BookID As Integer
        Get
            Return _bookID
        End Get
        Set(value As Integer)
            _bookID = value
        End Set
    End Property

End Class
