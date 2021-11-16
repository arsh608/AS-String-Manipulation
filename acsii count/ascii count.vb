Module Module1

    Sub Main()
        Dim str1 As String
        Dim x As Char
        Dim count, alphacount, digitcount, special As Integer

        str1 = ""
        x = ""
        count = 0
        alphacount = 0
        digitcount = 0
        special = 0

        Console.Write("Enter string to search in: ")
        str1 = Console.ReadLine

        For count = 1 To Len(str1)
            x = Mid(str1, count, 1)

            If (x >= "A" And x <= "Z") Or (x >= "a" And x <= "z") Then
                alphacount = alphacount + 1
            ElseIf x >= "0" And x <= "9" Then
                digitcount = digitcount + 1
            Else : special = special + 1
            End If

        Next

        Console.WriteLine("total charcters in the string are: " & (alphacount + digitcount + special))
        Console.WriteLine("Alphabats in the string are: " & alphacount)
        Console.WriteLine("Digits in the string are: " & digitcount)
        Console.WriteLine("Special Characters in the string are: " & special)

        Console.ReadKey()
    End Sub

End Module
