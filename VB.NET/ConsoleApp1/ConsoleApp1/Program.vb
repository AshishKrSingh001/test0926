Imports System

Module Program
    Sub Main(args As String())
        Dim n As Integer
        Console.WriteLine("Enter a number: ")
        n = CInt(Console.ReadLine())
        If n > 0 Then
            Console.WriteLine("+ve")
            If n Mod 2 = 0 Then
                Console.WriteLine("even")
            Else
                Console.WriteLine("odd")
            End If
        Else
            Console.WriteLine("-ve")
        End If
    End Sub
End Module
