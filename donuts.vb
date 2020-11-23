Module Module1

    Sub Main()
        Dim donuts As Integer
        Dim x As Integer
        donuts = 0

        Console.WriteLine("The purpose of this algorithm is to determine the number of donuts.")
        donuts = Console.ReadLine()

        If donuts <= 10 Then
            x = donuts

            Console.WriteLine("Number of donuts:  " & x & " where " & x & "  is the number.")

        ElseIf donuts >= 10 Then
            x = donuts

            Console.WriteLine("Number of donuts is many.")
        End If

        Console.ReadKey()

    End Sub

End Module
