Imports System
'1.3. Crear un proyecto y un m�dulo llamado concatenaci�n y en el declarar variables para almacenar
'los siguientes datos: nombre de la empresa, nombre de la calle, altura de la calle y fecha de
'inicio de actividades. Mostrar los mismos concatenados en la salida de la consola dos veces: la
'primera utilizando conversi�n expl�cita y la segunda conversi�n impl�cita.
Module concatenacion
    Sub Main(args As String())
        Dim nombreEmpresa As String = "Alguna empresa S.R.L"
        Dim nombreCalle As String = "tripoli"
        Dim Altura As UShort = 3399
        Dim fechaActividades As Date = #2000-01-31#
        Console.WriteLine("Conversi�n explicita :")
        Console.WriteLine("Nombre Empresa: " + nombreEmpresa & vbLf &
                          "Nombre Calle: " + nombreCalle & vbLf &
                          "Altura: " + Convert.ToString(Altura) + vbLf +
                          "Fecha Inicio Actividades: " + Convert.ToString(fechaActividades))

        Console.WriteLine(vbLf & "Conversi�n implicita :")
        Console.WriteLine("Nombre Empresa: " & nombreEmpresa & vbLf &
                          "Nombre Calle: " & nombreCalle & vbLf &
                          "Altura: " & Altura & vbLf &
                          "Fecha Inicio Actividades: " & fechaActividades)
    End Sub
End Module
