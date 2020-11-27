Module Module1

    Sub Main()

        Dim userinput As String
        Dim count As Integer
        Dim isPresent As Boolean

        userinput = ""
        count = 0
        isPresent = True

        Console.WriteLine("The purpose of this program is to take userinput greater than 3 characters and adding '-ing' to it. However, if the userinput already has '-ing' in it then the program will add '-ly' to it.")
        Console.WriteLine("Please enter your character:")
        userinput = Console.ReadLine()

            If Len(userinput) < 3 Then
                Console.WriteLine(userinput)


        ElseIf Len(userinput) >= 3 Then

            If userinput.Contains("ing") Then
                isPresent = True
                Console.WriteLine(userinput & "ly")

            Else
                isPresent = False
                Console.WriteLine(userinput & "ing")
            End If

        End If
        Console.ReadKey()

    End Sub

End Module
