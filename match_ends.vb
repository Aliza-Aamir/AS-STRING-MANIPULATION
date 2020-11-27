Module Module1

    Sub Main()

        Dim data, entereddata As String
        Dim firstchar, lastchar, x As Char
        Dim counter As Integer = 0
        entereddata = ""
        counter = 0
        data = "ABCDEFGHIJKLMNOPQRST"

        Console.WriteLine("The data: ABCDEFGHIJKLMNOPQRST.")
        Console.WriteLine("Enter data:")
        entereddata = Console.ReadLine()

        For counter = 0 To Len(entereddata)
            If Len(entereddata) >= 2 Then

                firstchar = Mid(entereddata, 1, 1)
                lastchar = Left(entereddata, 1)
                If firstchar = lastchar Then
                    counter = counter + 1

                End If
                Console.WriteLine(counter & firstchar)


            Else : Console.WriteLine("error")
            End If

        Next
        Console.ReadKey()

    End Sub

End Module
