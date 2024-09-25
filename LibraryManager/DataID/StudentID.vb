Public Class StudentID
    Private Shared _studentID As Integer
    Public Shared Property StudentID() As Integer
        Get
            Return _studentID
        End Get
        Set(value As Integer)
            _studentID = value
        End Set
    End Property
End Class
