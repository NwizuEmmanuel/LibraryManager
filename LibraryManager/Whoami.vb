Public Class Whoami
    Private Shared _firstname As String
    Private Shared _lastname As String
    Private Shared _phoneNumber As String
    Private Shared _ID As Integer

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

    Public Shared Property PhoneNumber() As String
        Get
            Return _phoneNumber
        End Get
        Set(value As String)
            _phoneNumber = value
        End Set
    End Property

    Public Shared Property ID As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property
End Class
