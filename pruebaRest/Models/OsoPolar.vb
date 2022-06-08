Public Class OsoPolar
    Public Property OsoId As Integer
    Public Property Nombre As String
    Public Property Color As String
    Public Property Edad As Integer

    Public Sub New()

    End Sub

    Public Sub New(ByVal id As Integer,
                   ByVal nombrep As String,
                   ByVal colorp As String,
                   ByVal edadp As Integer)
        OsoId = id
        Nombre = nombrep
        Color = colorp
        Edad = edadp
    End Sub
End Class
