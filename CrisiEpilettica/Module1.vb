Module Module1

    Sub Main()
        Dim a As Double
        Console.Title = "Crisi epilettica"
        Console.Write("Inserisci un numero diverso da 5: ")
        a = Console.ReadLine()
        Do
            Console.BackgroundColor = ConsoleColor.Black
            Console.Clear()
            Console.BackgroundColor = ConsoleColor.Blue
            Console.Clear()
            Console.BackgroundColor = ConsoleColor.Cyan
            Console.Clear()
            Console.BackgroundColor = ConsoleColor.DarkBlue
            Console.Clear()
            Console.BackgroundColor = ConsoleColor.DarkCyan
            Console.Clear()
            Console.BackgroundColor = ConsoleColor.DarkGray
            Console.Clear()
            Console.BackgroundColor = ConsoleColor.DarkGreen
            Console.Clear()
            Console.BackgroundColor = ConsoleColor.DarkMagenta
            Console.Clear()
            Console.BackgroundColor = ConsoleColor.DarkRed
            Console.Clear()
            Console.BackgroundColor = ConsoleColor.DarkYellow
            Console.Clear()
            Console.BackgroundColor = ConsoleColor.Gray
            Console.Clear()
            Console.BackgroundColor = ConsoleColor.Green
            Console.Clear()
            Console.BackgroundColor = ConsoleColor.Magenta
            Console.Clear()
            Console.BackgroundColor = ConsoleColor.Red
            Console.Clear()
            Console.BackgroundColor = ConsoleColor.White
            Console.Clear()
            Console.BackgroundColor = ConsoleColor.Yellow
            Console.Clear()
        Loop Until a = 5
        Console.ForegroundColor = ConsoleColor.White
        Console.BackgroundColor = ConsoleColor.Black
        Console.Clear()
        Console.WriteLine("Perché hai messo 5 stupido?!?!")
        Console.WriteLine("Bah, contento te...")
        Console.ReadKey()
    End Sub

End Module
