Module Module1

    Sub Main()
        Dim str1, str2, str3, str4 As String
        Dim count1, count2 As Integer
        Dim char1, char2, thischar1, thischar2 As Char

        str1 = ""
        str2 = ""
        str3 = ""
        str4 = ""
        count1 = 0
        count2 = 0
        char1 = ""
        char2 = ""
        thischar1 = ""
        thischar2 = ""


        Console.Write("Enter ONLY the first word: ")
        str1 = Console.ReadLine()
        Console.Write("Enter ONLY the second word: ")
        str2 = Console.ReadLine()

        char1 = Left(str1, 1)
        char2 = Left(str2, 1)

        str3 = char2 & Right(str1, (Len(str1) - 1))
        str4 = char1 & Right(str2, (Len(str2) - 1))



        Console.Write("The processed string is: " & str3 & " " & str4)
        Console.ReadKey()
    End Sub

End Module
