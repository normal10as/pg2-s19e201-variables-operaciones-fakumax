Imports System
'1.19. Crear un proyecto y un m�dulo llamado �d�as� utilizando una enumeraci�n para los d�as
'de la semana en espa�ol, mostrar que d�a que corresponde al resultado.}

Module dias
    Enum semanaDias
        Lunes
        Martes
        Miercoles
        Jueves
        Viernes
        Sabado
        Domingo
    End Enum
    Sub Main(args As String())
        Console.WriteLine("{0} - valor: {1}", semanaDias.Lunes.ToString, semanaDias.Lunes.GetHashCode)
        Console.WriteLine("{0} - valor: {1}", semanaDias.Martes.ToString, semanaDias.Martes.GetHashCode)
        Console.WriteLine("{0} - valor: {1}", semanaDias.Miercoles.ToString, semanaDias.Miercoles.GetHashCode)
        Console.WriteLine("{0} - valor: {1}", semanaDias.Jueves.ToString, semanaDias.Jueves.GetHashCode)
        Console.WriteLine("{0} - valor: {1}", semanaDias.Viernes.ToString, semanaDias.Viernes.GetHashCode)
        Console.WriteLine("{0} - valor: {1}", semanaDias.Sabado.ToString, semanaDias.Sabado.GetHashCode)
        Console.WriteLine("{0} - valor: {1}", semanaDias.Domingo.ToString, semanaDias.Domingo.GetHashCode)

    End Sub
End Module
