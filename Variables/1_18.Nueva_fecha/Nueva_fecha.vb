Imports System
'1.18. Crear un proyecto y un m�dulo llamado �Nueva_fecha� que se ingrese una fecha y un
'n�mero dados de d�as, Mostrar como resultado la fecha obtenida de sumar la cantidad de d�as a
'la fecha dada.
Module Nueva_fecha
    Sub Main(args As String())
        Dim fechaInicial As Date
        Dim diasAgregados As UShort
        Console.Write("Ingrese una fecha (AAAA-MM-DD) : ")
        fechaInicial = Console.ReadLine
        Console.Write("Ingrese cantidad dias a sumar : ")
        diasAgregados = Console.ReadLine
        Console.WriteLine("La fecha Inicial es : " & fechaInicial)
        Console.WriteLine("La fecha Final es : " & fechaInicial.AddDays(diasAgregados))
    End Sub
End Module
