Imports System
Imports System.Math
'1.13. Crear un proyecto y un m�dulo llamado �Mayor� que lea tres n�meros y muestre el
'mayor.
Module Mayor
    Sub Main(args As String())
        Dim valorA As Integer
        Dim valorB As Integer
        Dim valorC As Integer
        Dim maximo As Integer
        Console.WriteLine("Ingrese un n�mero : ")
        valorA = Console.ReadLine
        Console.WriteLine("Ingrese un n�mero : ")
        valorB = Console.ReadLine
        Console.WriteLine("Ingrese un n�mero : ")
        valorC = Console.ReadLine
        maximo = Max(valorA, valorB)
        maximo = Max(maximo, valorC)
        Console.WriteLine("El mayor es : " & maximo)
    End Sub
End Module
