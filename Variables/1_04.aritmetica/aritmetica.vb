Imports System
'1.4. Crear un proyecto y un m�dulo llamado aritm�tica que declare y asigne dos valores enteros y
'dos valores de punto flotante. Luego demostrar las operaciones aritm�ticas b�sicas mezclando
'los tipos de datos utilizados y mostrar los resultados por consola previo un mensaje adecuado.
'Por ejemplo: sumar entero con entero, entero con punto flotante y punto flotante con punto
'flotante.
Module aritmetica
    Sub Main(args As String())
        Dim EnteroA As Integer = 22
        Dim EnteroB As Integer = 10
        Dim FlotanteA As Single = 12.32
        Dim FlotanteB As Single = 1.3
        Console.WriteLine("SUMA")
        Console.WriteLine("Suma entero y entero : {0} + {1} = {2} ", EnteroA, EnteroB, EnteroA + EnteroB)
        Console.WriteLine("Suma entero y punto flotante : {0} + {1} = {2} ", EnteroA, FlotanteA, EnteroA + FlotanteA)
        Console.WriteLine("Suma Punto flotante y punto flotante : {0} + {1} = {2} ", FlotanteA, FlotanteB, FlotanteA + FlotanteB)
        Console.WriteLine(vbLf & "RESTA")
        Console.WriteLine("Resta entero y entero : {0} - {1} = {2} ", EnteroA, EnteroB, EnteroA - EnteroB)
        Console.WriteLine("Resta entero y punto flotante : {0} - {1} = {2} ", EnteroA, FlotanteA, EnteroA - FlotanteA)
        Console.WriteLine("Resta Punto flotante y punto flotante : {0} - {1} = {2} ", FlotanteA, FlotanteB, FlotanteA - FlotanteB)
        Console.WriteLine(vbLf & "MULTIPLICACION")
        Console.WriteLine("Multiplicaci�n entero y entero : {0} * {1} = {2} ", EnteroA, EnteroB, EnteroA * EnteroB)
        Console.WriteLine("Multiplicaci�n entero y punto flotante : {0} * {1} = {2} ", EnteroA, FlotanteA, EnteroA * FlotanteA)
        Console.WriteLine("Multiplicaci�n Punto flotante y punto flotante : {0} * {1} = {2} ", FlotanteA, FlotanteB, FlotanteA * FlotanteB)
        Console.WriteLine(vbLf & "DIVISION")
        Console.WriteLine("Divisi�n entero y entero : {0} / {1} = {2} ", EnteroA, EnteroB, EnteroA / EnteroB)
        Console.WriteLine("Divisi�n entero y punto flotante : {0} / {1} = {2} ", EnteroA, FlotanteA, EnteroA / FlotanteA)
        Console.WriteLine("Divisi�n Punto flotante y punto flotante : {0} / {1} = {2} ", FlotanteA, FlotanteB, FlotanteA / FlotanteB)

    End Sub
End Module
