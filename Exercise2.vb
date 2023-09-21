Module Exercise2
    'Brooks Keller
    'excersise 2
    '9/21/23
    Sub main()
        Dim c1, c2, c3 As String
        Dim p1, p2, p3 As String
        Dim name As String

        Console.Write("Please enter your name -> ")
        name = Console.ReadLine
        Console.WriteLine("Hello " & name & vbNewLine)

        Console.Write("Please look up for me the top 3 most populated countries today")
        Console.WriteLine("")
        Console.WriteLine("")

        Console.Write("What is the first country? -> ") 'getting all of this data
        c1 = Console.ReadLine
        Console.Write("What is it's population? -> ")
        p1 = Console.ReadLine
        Console.Write("What is the second country? -> ")
        c2 = Console.ReadLine
        Console.Write("What is it's population? -> ")
        p2 = Console.ReadLine
        Console.Write("What is the third country? -> ")
        c3 = Console.ReadLine
        Console.Write("What is it's population? -> ")
        p3 = Console.ReadLine

        Console.WriteLine("Thank you. Here is the data I collected.")
        Console.WriteLine("I am converting all country names to all caps, because they have a lot of people!")

        Console.WriteLine("".PadRight(42, "-"))
        Console.WriteLine("| {0} | {1} |", "Country".PadRight(15), "Population".PadRight(20))
        Console.WriteLine("".PadRight(42, "-"))
        Console.WriteLine("| {0} | {1} |", c1.ToUpper.PadRight(15), p1.PadRight(20))
        Console.WriteLine("| {0} | {1} |", c2.ToUpper.PadRight(15), p2.PadRight(20))
        Console.WriteLine("| {0} | {1} |", c3.ToUpper.PadRight(15), p3.PadRight(20))
        Console.WriteLine("".PadRight(42, "-"))

    End Sub
End Module
