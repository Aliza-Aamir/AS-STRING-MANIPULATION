Module Module1

    Sub Main()
        Dim userinput1, userinput2, str1, str2, str3, str4 As String
        Dim count As Integer

        count = 0
        userinput1 = ""
        userinput2 = ""
        str1 = ""
        str2 = ""
        str3 = ""
        str4 = ""

        Console.WriteLine("The purpose of this program is to return a single string in which the first two characters of the two inputs entered would be  swapped.e.g. 'pod mix' will give 'mid pox.")
        Console.WriteLine("Please enter your first string:")
        userinput1 = Console.ReadLine()
        Console.WriteLine("Please enter your second string:")
        userinput2 = Console.ReadLine()

        For count = 1 To Len(userinput1)
            str1 = Mid(userinput1, 1, 2)
            str2 = Mid(userinput2, 1, 2)
            str3 = Mid(userinput2, 3, Len(userinput2))
            str4 = Mid(userinput1, 3, Len(userinput1))
        Next
        Console.WriteLine(" YOUR OUTPUT: " & str2 & str4 & " " & str1 & str3)

        Console.ReadKey()

    End Sub

End Module
