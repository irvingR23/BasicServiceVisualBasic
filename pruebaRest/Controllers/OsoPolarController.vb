Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class OsoPolarController
        Inherits ApiController

        Shared listaOsosPolares As List(Of OsoPolar) = New List(Of OsoPolar) From
            {
                New OsoPolar(1, "Rubby", "white", 2),
                New OsoPolar(2, "Tiny", "white with dots", 3),
                New OsoPolar(3, "Emilia", "white", 1),
                New OsoPolar(4, "Cute", "white", 1),
                New OsoPolar(5, "Marshmallow", "white", 2)
            }


        ' GET: api/OsoPolar
        Public Function GetValues() As IEnumerable(Of OsoPolar)
            Return listaOsosPolares
        End Function

        ' GET: api/OsoPolar/5
        Public Function GetValue(ByVal id As Integer) As OsoPolar
            Dim oso = listaOsosPolares.Find(Function(x) x.OsoId = id)
            Return oso
        End Function

        ' POST: api/OsoPolar
        Public Sub PostValue(<FromBody()> ByVal value As OsoPolar)
            Debug.Print("hola mundo")
            listaOsosPolares.Add(value)
            Debug.Print(listaOsosPolares.Last.Nombre)
        End Sub

        ' PUT: api/OsoPolar/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As OsoPolar)
            Dim index = listaOsosPolares.FindIndex(Function(x) x.OsoId = id)
            listaOsosPolares(index) = value
        End Sub

        ' DELETE: api/OsoPolar/5
        Public Sub DeleteValue(ByVal id As Integer)
            Dim index = listaOsosPolares.FindIndex(Function(x) x.OsoId = id)
            listaOsosPolares.RemoveAt(index)
        End Sub
    End Class
End Namespace