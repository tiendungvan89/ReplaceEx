Public Class SrcDst

    Private prmDst As String
    Private prmSrc As String

    Public Property Dst() As String
        Get
            Return prmDst
        End Get
        Set(ByVal value As String)
            prmDst = value
        End Set
    End Property

    Public Property Src() As String
        Get
            Return prmSrc
        End Get
        Set(ByVal value As String)
            prmSrc = value
        End Set
    End Property
End Class
