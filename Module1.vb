Module Module1
    'Brooks Keller
    'Exercise 1
    '9/20/23
    Sub Main()
        Dim name As String 'variables defined
        Dim movie As String
        Dim song As String
        Dim food As String
        Dim act As String

        Console.Write("Please enter your name -> ") 'name entering system
        name = Console.ReadLine
        Console.WriteLine("Hello " & name & vbNewLine) 'added vbnewline for uniform

        Console.Write("Please enter your favorite movie -> ") 'prompting for input here
        movie = Console.ReadLine 'console reads what movie the user entered here

        Console.Write("Please enter your favorite song -> ")
        song = Console.ReadLine

        Console.Write("Please enter your favorite food -> ")
        food = Console.ReadLine

        Console.Write("Please enter your favorite activity -> ")
        act = Console.ReadLine
        Console.WriteLine("")

        Console.WriteLine("Thank you. Here's the profile I have for you:")

        Console.WriteLine("".PadRight(50, "-")) 'and the list begins

        Console.WriteLine("| {1} | {2} ", "1", "Name".PadRight(25), name.PadRight(25))
        Console.WriteLine("| {1} | {2} ", "1", "Favorite Movie".PadRight(25), movie.PadRight(25))
        Console.WriteLine("| {1} | {2} ", "1", "Favorite Song".PadRight(25), song.PadRight(25))
        Console.WriteLine("| {1} | {2} ", "1", "Favorite Food".PadRight(25), food.PadRight(25))
        Console.WriteLine("| {1} | {2} ", "1", "Favorite Activity".PadRight(25), act.PadRight(25))

        Console.WriteLine("".PadRight(50, "-"))
    End Sub

End Module
