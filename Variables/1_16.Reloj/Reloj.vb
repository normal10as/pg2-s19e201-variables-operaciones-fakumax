Imports System
'1.16. Crear un proyecto y un m�dulo llamado �Reloj� que muestre en l�neas diferentes con sus
'correspondientes t�tulos los siguientes valores en el momento de la ejecuci�n: d�a del a�o, mes,
'hora y minuto
Module Reloj
    Sub Main(args As String())
        Console.WriteLine("D�a del a�o : " & DateTime.Now.Day())
        Console.WriteLine("Mes del a�o : " & DateTime.Now.Month())
        Console.WriteLine("Hora y minutos : " & DateTime.Now.ToShortTimeString)
    End Sub
End Module
