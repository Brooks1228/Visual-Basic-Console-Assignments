Module Exercise3
    'Brooks Keller
    'Excercise 3
    '9/21/23
    Sub main()
        Dim d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12 As String
        Dim name As String

        Console.Write("Please enter your name -> ")
        name = Console.ReadLine
        Console.WriteLine("Hello " & name & vbNewLine)

        Console.WriteLine("Please look up for me the following information technology abbreviations")
        Console.WriteLine()
        Console.WriteLine()

        Console.Write("Please tell me what ""A/D"" stands for -> ")
        d1 = Console.ReadLine
        Console.Write("Please tell me what ""AI"" stands for -> ")
        d2 = Console.ReadLine
        Console.Write("Please tell me what ""ASCII"" stands for -> ")
        d3 = Console.ReadLine
        Console.Write("Please tell me what ""BIOS"" stands for -> ")
        d4 = Console.ReadLine
        Console.Write("Please tell me what ""CLI"" stands for -> ")
        d5 = Console.ReadLine
        Console.Write("Please tell me what ""DBMS"" stands for -> ")
        d6 = Console.ReadLine
        Console.Write("Please tell me what ""DDS"" stands for -> ")
        d7 = Console.ReadLine
        Console.Write("Please tell me what ""FAT"" stands for -> ")
        d8 = Console.ReadLine
        Console.Write("Please tell me what ""FTP"" stands for -> ")
        d9 = Console.ReadLine
        Console.Write("Please tell me what ""OS"" stands for -> ")
        d10 = Console.ReadLine
        Console.Write("Please tell me what ""RAM"" stands for -> ")
        d11 = Console.ReadLine
        Console.Write("Please tell me what ""ROM"" stands for -> ")
        d12 = Console.ReadLine
        Console.WriteLine()

        Console.WriteLine("Thank you. I will now print out my records with the definitions all lowercased to demonstrate the toLower functionality")
        Console.WriteLine("".PadRight(100, "-"))
        Console.WriteLine("A/D:" & d1.ToLower)
        Console.WriteLine("AI:" & d2.ToLower)
        Console.WriteLine("ASCII:" & d3.ToLower)
        Console.WriteLine("BIOS:" & d4.ToLower)
        Console.WriteLine("CLI:" & d5.ToLower)
        Console.WriteLine("DBMS:" & d6.ToLower)
        Console.WriteLine("DOS:" & d7.ToLower)
        Console.WriteLine("FAT:" & d8.ToLower)
        Console.WriteLine("FTP:" & d9.ToLower)
        Console.WriteLine("OS:" & d10.ToLower)
        Console.WriteLine("RAM:" & d11.ToLower)
        Console.WriteLine("ROM:" & d12.ToLower)
        Console.WriteLine("".PadRight(100, "-"))
    End Sub
End Module
