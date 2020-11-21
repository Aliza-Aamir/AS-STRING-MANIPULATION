Module Module1

    Sub Main()
        Dim str1, str2 As String
        Dim chr1, chr2 As String
        Dim counter As Integer
        Dim nextchar As String
        str1 = ""
        str2 = ""
        chr1 = ""
        chr2 = ""
        count = 0
        nextchar = ""
        Console.WriteLine("The purpose of this program is to replace a certain character from a string and replace it with another.")

        Console.WriteLine("Please enter a string:")
        str1 = Console.ReadLine

        Console.WriteLine("Enter the character you wish to remove:")
        chr1 = Console.ReadLine

        Console.WriteLine("Enter the character you wish to put in place of the one removed:")
        chr2 = Console.ReadLine

        For Counter = 1 To Len(str1)
            nextChar = Mid(str1, Counter, 1)
            If nextchar = chr1 Then
                nextchar = chr2
            End If
            str2 = str2 & nextChar
        Next

        Console.WriteLine("Final string = " & str2)
        Console.ReadKey()


    End Sub
End Module


