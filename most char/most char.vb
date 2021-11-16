Module Module1

    Sub Main()
        Dim mosttime, char1, char2 As Char
        Dim count1, count2, count, most As Integer
        Dim sentence As String

        sentence = ""
        char1 = ""
        char2 = ""
        mosttime = ""
        count1 = 0
        count2 = 0
        count = 0
        most = 0

        Console.Write("Enter the sentence: ")
        sentence = Console.ReadLine()
        For count1 = 1 To Len(sentence)
            char1 = Mid(sentence, count1, 1)
            count = 0
            For count2 = 1 To Len(sentence)
                char2 = Mid(sentence, count2, 1)
                If char1 = char2 Then count = count + 1

                If count > most Then
                    mosttime = char2
                    most = count
                End If
            Next
        Next
        Console.Write(mosttime & " appeared " & most & " times in your sentence")

        Console.ReadKey()

    End Sub

End Module
