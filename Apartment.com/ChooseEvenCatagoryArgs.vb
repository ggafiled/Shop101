Public Delegate Sub ChooseEvenCatagoryHandler(ByVal source As Object, ByVal e As ChooseEvenCatagoryArgs)
Public Class ChooseEvenCatagoryArgs
    Inherits EventArgs

    Private _catagoryID As String
    Private _catagoryName As String

    Public Sub New(ByVal _id As String, ByVal _name As String)
        _catagoryID = _id
        _catagoryName = _name
    End Sub

    Public ReadOnly Property CatagoryID() As String
        Get
            Return _catagoryID
        End Get
    End Property

    Public ReadOnly Property CatagoryNAME() As String
        Get
            Return _catagoryName
        End Get
    End Property

End Class
