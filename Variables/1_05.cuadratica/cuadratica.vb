Imports System
'1.5. Crear un proyecto y un m�dulo llamado �Cuadratica� que resuelva la siguiente ecuaci�n X = (b^2-4*a*c)/(2*a)
'donde a=1, b=5 y c = 2
'Mostrar el resultado obtenido.
Module cuadratica
    Sub Main(args As String())
        Dim a As Integer = 1
        Dim b As Integer = 5
        Dim c As Integer = 2
        Console.WriteLine("El resultado es : " & (b ^ 2 - 4 * a * c) / (2 * a))
    End Sub
End Module