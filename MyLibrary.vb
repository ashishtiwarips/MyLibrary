Namespace MyLibrary
    Public Class GreetingsHelper
        Public Shared Function BuildGreeting(name As String, color As String) As String
            Return $"Hello, {name}! Your favorite color (colour) is {color}."
        End Function
    End Class
End Namespace

