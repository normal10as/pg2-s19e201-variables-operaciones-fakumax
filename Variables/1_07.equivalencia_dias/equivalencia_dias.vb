Imports System
'1.7. Crear un proyecto y un m�dulo llamado �equivalencia_dias� y en el declarar las siguientes
'constantes: d�as por semana, horas por d�a y minutos por hora. Ingresar un numero cualquiera de
'd�as e informar que corresponde a n�mero de semanas, n�mero de horas y n�mero de minutos.
Module equivalencia_dias
    Sub Main(args As String())
        Const diaSemana As Byte = 7
        Const horaDia As Byte = 24
        Const minutoHora As Byte = 60
        Dim dias As Integer
        Console.WriteLine("Ingrese un n�mero de d�as")
        dias = Console.ReadLine
        Console.WriteLine("El n�mero de 'Semanas' es : " & dias \ diaSemana)
        Console.WriteLine("El n�mero de 'Horas' es : " & dias * horaDia)
        Console.WriteLine("El n�mero de 'Minutos' es : " & dias * horaDia * minutoHora)
    End Sub
End Module
