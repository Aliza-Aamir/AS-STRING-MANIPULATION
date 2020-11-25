Module Module1

    Sub Main()
        Dim userinput, alphabets As String
        Dim nextChar As Char
        Dim Count As Integer
        Dim isPangram As Boolean

        userinput = ""
        alphabets = "abcdefghijklmnopqrstuvwxyz"
        nextChar = ""
        Count = 0
        isPangram = True
        Console.WriteLine("The purpose of this program is to check whether or not your sentence is a pangram. i.e whether it has all the alphabets.")
        Console.Write("Enter your sentence: ")
        userinput = Console.ReadLine
        userinput = LCase(userinput)

        For Count = 1 To Len(alphabets)
            nextChar = Mid(alphabets, Count, 1)
            If InStr(userinput, nextChar) = 0 Then
                isPangram = False
                Exit For
            End If
        Next

        If isPangram = True Then
            Console.WriteLine("Your sentence contains all of the alphabets, therefore it is a pangram.")
        Else
            Console.WriteLine("Your sentence doesn't contain all of the alphabets therefore it isn't a Pangram.")
        End If
        Console.ReadKey()
    End Sub

End Module

