Module Module1

    Sub Main()
        Dim str1, str2, str3 As String

        str1 = ""
        str2 = ""
        str3 = ""

        Console.Write("Enter the string: ")
        str1 = Console.ReadLine

        If Len(str1) <= 2 Then
            Console.Write("The answer is: " & str1)
        Else
            str2 = Left(str1, 2)
            str3 = Right(str1, 2)
            Console.Write("The answer is: " & str2 & str3)

        End If
        Console.ReadKey()

    End Sub

End Module
