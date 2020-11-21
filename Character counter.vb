Module Module1

    Sub Main()
        Dim userinput As String
        Dim x As Integer


        Console.WriteLine("Please input a string of characters and this algorithm will count it.")
        userinput = Console.ReadLine()
        x = Len(userinput)
        Console.WriteLine("The number of entered characters including spaces is: " & x)

        Console.Read()
    End Sub

End Module

