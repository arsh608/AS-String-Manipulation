Module Module1

    Sub Main()
        Dim count, alphapos As Integer
        Dim str1, alpha As String
        Dim thischar As Char
        Dim isPangram As Boolean

        str1 = ""
        thischar = ""
        isPangram = True
        count = 0
        alphapos = 0
        alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"

        Console.Write("Enter the string to check: ")
        str1 = Console.ReadLine
        str1 = UCase(str1)


        For count = 1 To Len(alpha)
            thischar = Mid(alpha, count, 1)
            alphapos = InStr(str1, thischar)
            If alphapos = 0 Then
                isPangram = False
                Exit For
            End If
        Next

        If isPangram = True Then
            Console.WriteLine("Entered string is a Pangram.")
        Else
            Console.WriteLine("Entered string is NOT a Pangram.")
        End If
        Console.ReadKey()
    End Sub

End Module
