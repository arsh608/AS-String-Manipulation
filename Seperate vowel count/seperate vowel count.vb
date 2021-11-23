Module Module1

    Sub Main()
        Dim str1 As String
        Dim thischar As Char
        Dim count, VowelCount, Acount, Ecount, Icount, Ocount, Ucount As Integer

        str1 = ""
        thischar = ""
        VowelCount = 0
        count = 0
        Acount = 0
        Ecount = 0
        Icount = 0
        Ocount = 0
        Ucount = 0

        Console.Write("Enter the string to count Vowels: ")
        str1 = UCase(Console.ReadLine())

        For count = 1 To Len(str1)
            thischar = Mid(str1, count, 1)

            Select Case (thischar)
                Case "A" : Acount = Acount + 1
                Case "E" : Ecount = Ecount + 1
                Case "I" : Icount = Icount + 1
                Case "O" : Ocount = Ocount + 1
                Case "U" : Ucount = Ucount + 1

            End Select
        Next

        VowelCount = Acount + Ecount + Icount + Ocount + Ucount
        Console.WriteLine("Total Vowels in the given string are= " & VowelCount)
        Console.WriteLine("A= " & Acount)
        Console.WriteLine("E= " & Ecount)
        Console.WriteLine("I= " & Icount)
        Console.WriteLine("O= " & Ocount)
        Console.WriteLine("U= " & Ucount)

        Console.ReadKey()

    End Sub

End Module
