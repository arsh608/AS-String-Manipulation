Module Module1

    Sub Main()
        Dim str1, finalstr As String
        Dim thischar, char1, aceteric As Char
        Dim counter As Integer

        str1 = ""
        finalstr = ""
        thischar = ""
        char1 = ""
        counter = 0
        aceteric = "*"

        Console.Write("Enter the string: ")
        str1 = UCase(Console.ReadLine())
        char1 = Left(str1, 1)
        finalstr = char1

        For counter = 2 To Len(str1)
            thischar = Mid(str1, counter, 1)
            If thischar = char1 Then
                finalstr = finalstr + aceteric
            Else : finalstr = finalstr + thischar

            End If
        Next

        Console.Write("The processed string is: " & LCase(finalstr))
        Console.ReadKey()

    End Sub

End Module
