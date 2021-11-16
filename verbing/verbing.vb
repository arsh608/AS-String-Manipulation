Module Module1

    Sub Main()
        Dim str1, str2, verb As String

        str1 = ""
        str2 = ""
        verb = "ing"

        Console.Write("Enter the string: ")
        str1 = Console.ReadLine()

        If Len(str1) < 3 Then
            Console.Write("The final string is: " & str1)
        Else
            str2 = Right(str1, 3)

            If str2 = verb Then
                str1 = str1 + "ly"
            Else
                str1 = str1 + verb
            End If

            Console.Write("The processed string is: " & str1)

        End If

        Console.ReadKey()

    End Sub

End Module
