Public Class Whoami
    Private Shared _firstname As String
    Private Shared _lastname As String

    Public Shared Property Firstname() As String
        Get
            Return _firstname
        End Get
        Set(value As String)
            _firstname = value
        End Set
    End Property

    Public Shared Property Lastname() As String
        Get
            Return _lastname
        End Get
        Set(value As String)
            _lastname = value
        End Set
    End Property
End Class
