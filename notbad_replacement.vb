Module Module1

    Sub Main()

        Dim userinput, finalstring As String
        Dim count As Integer

        userinput = ""
        finalstring = 0

        Console.WriteLine("This program changes the words: 'not bad' within your entered string with 'good'.")
        Console.WriteLine("Please enter your input:")
        userinput = Console.ReadLine()

        For count = 1 To Len(userinput)
            finalstring = userinput.Replace("not bad", "good")

        Next
        Console.WriteLine("Your output is: " & finalstring)

        Console.ReadKey()

    End Sub

End Module
