Imports System
'1.9. Crear un proyecto y un m�dulo llamado �Interes� que d� como resultado los intereses
'producidos y el capital acumulado de un monto m invertido a un inter�s anual r durante t d�as.
'La f�rmula utilizada es I= (m*r*t)/(360*100) donde I es el inter�s producido. 
'Ingresar por teclado el monto, el inter�s y el tiempo.
Module Interes
    Sub Main(args As String())
        Dim montoInversion As Decimal
        Dim interesAnual As Single
        Dim tiempoDias As UShort
        Console.WriteLine("Ingrese el monto a invertir : ")
        montoInversion = Console.ReadLine
        Console.WriteLine("Ingrese el inter�s anual: ")
        interesAnual = Console.ReadLine
        Console.WriteLine("Ingrese la cantidad de d�as : ")
        tiempoDias = Console.ReadLine
        Console.WriteLine(vbLf & "Capital Ingresado : " & montoInversion &
                          vbLf & "Inter�s Anual en % : " & interesAnual &
                          vbLf & "Tiempo en dias de inversi�n : " & tiempoDias &
                          vbLf & vbLf & "El Interes Total Producido ser�a : " &
                          (montoInversion * interesAnual * tiempoDias) / (360 * 100))

    End Sub
End Module
