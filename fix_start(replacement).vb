Module Module1

    Sub Main()
        Dim userinput As String
        Dim firstchar As Char
        Dim myChar As Char

        Console.WriteLine("The program outputs all the occurrences of its first char being changed to '*', except the first char itself.")
        Console.WriteLine("Enter a statement")
        userinput = Console.ReadLine

        firstchar = Left(userinput, 1)
        Console.Write(firstchar)
        For COUNT = 1 To Len(userinput) - 1
            myChar = Mid(userinput, (COUNT + 1), 1)
            If myChar = firstchar Then
                myChar = "*"
            End If
            Console.Write(myChar)
        Next
        Console.ReadKey()
    End Sub
End Module
