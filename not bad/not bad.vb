Module Module1

    Sub Main()
        Dim str1, str2 As String
        Dim count, notPos, badPos As Integer
        Dim thischar As Char

        str1 = ""
        str2 = ""
        thischar = ""
        count = 0
        badPos = 0
        notPos = 0

        Console.Write("Enter the string: ")
        str1 = LCase(Console.ReadLine())

        notPos = InStr(str1, "not")
        If notPos = 0 Then
            Console.Write("String does not contain the word 'not' ")
            Console.ReadKey()
            End
        Else
            badPos = InStr(str1, "bad")
            If badPos = 0 Then
                Console.Write("String does not contain the word 'bad' ")
                Console.ReadKey()
                End

            ElseIf notPos > badPos Then
                Console.Write("String Unchanged: " & str1)
            End If
        End If




        If notPos < badPos Then
            For count = 1 To Len(str1)
                thischar = Mid(str1, count, 1)

                If count = notPos Then
                    str2 = str2 + "good"
                    count = badPos + 3
                Else
                    str2 = str2 + thischar
                End If
            Next
            Console.Write("The processed string is: " & str2)
        End If

        Console.ReadKey()
    End Sub

End Module
