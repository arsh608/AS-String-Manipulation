Module Module1

    Sub Main()
        Dim str1, str2, char1, char2, thischar As String
        Dim count As Integer

        str1 = ""
        str2 = ""
        char1 = ""
        char2 = ""
        thischar = ""
        count = 0

        Console.Write("Enter the String: ")
        str1 = Console.ReadLine

        Console.Write("Enter the character to remove: ")
        char1 = Console.ReadLine

        Console.Write("Enter the character to replace with: ")
        char2 = Console.ReadLine

        For count = 1 To Len(str1)
            thischar = Mid(str1, count, 1)
            If thischar = char1 Then
                thischar = char2
            End If
            str2 = str2 & thischar
        Next

        Console.WriteLine("Processed string = " & str2)
        Console.ReadKey()
    End Sub

End Module
