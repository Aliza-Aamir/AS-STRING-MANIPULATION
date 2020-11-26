Module Module1

    Sub Main()

        Dim userinput, str1, str2 As String
        Dim count As Integer


        userinput = ""
        str1 = ""
        str2 = ""
        count = 0

        Console.WriteLine("The purpose of this program is to return a string composed of the first and last 2 characters of the orginal string.")
        Console.WriteLine("Input character:")
        userinput = Console.ReadLine()

        If Len(userinput) > 2 Then
            For count = 1 To Len(userinput)
                str1 = Mid(userinput, 1, 2)
                str2 = Right(userinput, 2)
            Next
            Console.WriteLine("Your output is: " & str1 & str2)

        ElseIf Len(userinput) <= 2 Then
            Console.WriteLine(userinput)
        End If

        Console.ReadLine()
    End Sub

End Module
