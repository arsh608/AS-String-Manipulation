Module Module1

    Sub Main()
        Dim str1, V As String
        Dim thischar As Char
        Dim count, VowelCount As Integer

        str1 = ""
        thischar = ""
        VowelCount = 0
        count = 0
        V = "AEIOU"

        Console.Write("Enter the string to count Vowels: ")
        str1 = UCase(Console.ReadLine())

        For count = 1 To Len(str1)
            thischar = Mid(str1, count, 1)
            If InStr(V, thischar) > 0 Then
                VowelCount = VowelCount + 1
            End If
        Next

        Console.WriteLine("Vowels in the given string are= " & VowelCount)
        Console.ReadKey()

    End Sub

End Module
