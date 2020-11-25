Module Module1

    Sub Main()
        Dim myChar, thisChar, nextChar As Char
        Dim freq_num, Count, x, y As Integer
        Dim userinput As String

        myChar = ""
        freq_num = 0
        Count = 0
        Console.WriteLine("The purpose of this program is to count the frequently occurring  characters in an entered sentence.")
        Console.Write("Please enter your sentence: ")
        userinput = Console.ReadLine

        For x = 1 To Len(userinput)
            nextChar = Mid(userinput, x, 1)
            Count = 0
            For y = 1 To Len(userinput)
                thisChar = Mid(userinput, y, 1)
                If thisChar = nextChar Then Count = Count + 1
            Next

            If Count > freq_num Then
                freq_num = Count
                myChar = nextChar
            End If
        Next
        Console.WriteLine("The letter " & myChar & " appeared  " & freq_num & " number of times.")
        Console.ReadKey()
    End Sub

End Module

