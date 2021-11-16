Module Module1

    Sub Main()
        Dim D As Integer


        D = 0

        Console.Write("Enter Number of DONUTS: ")
        D = Console.ReadLine
        If D >= 0 And D < 10 Then
            Console.Write(D & " DONUTS are ordered")
        ElseIf D >= 10 Then
            Console.Write("Many DONUTS are ordered")
        End If
        Console.ReadKey()
    End Sub

End Module
