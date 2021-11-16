Module Module1

    Sub Main()
        Dim str1, str2, str3, str4, i, j As String
        Dim count1, count2 As Integer

        str1 = ""
        str2 = ""
        str3 = ""
        str4 = ""
        count1 = 0
        count2 = 0
        i = ""
        j = ""


        Console.Write("Enter ONLY the first word: ")
        str1 = Console.ReadLine()
        Console.Write("Enter ONLY the second word: ")
        str2 = Console.ReadLine()

        i = Left(str1, 2)
        j = Left(str2, 2)

        str3 = j & Right(str1, (Len(str1) - 2))
        str4 = i & Right(str2, (Len(str2) - 2))


        Console.Write("The processed string is: " & str3 & " " & str4)
        Console.ReadKey()

    End Sub

End Module
