Module Module1

    Sub Main()
        Dim dagen As Integer() = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}
        Dim maanden As String() = {"januari", "februari", "maart", "april",
                                 "mei", "juni", "juli", "augustus",
                                 "september", "oktober", "november", "december"}
        Dim weekdagen As String() = {"maandag", "dinsdag", "woensdag", "donderdag", "vrijdag",
                                   "zaterdag", "zondag"}
        Dim ingegevenMaand As Integer

        Console.Write("Maand in 2014? (1-12): ")
        Console.ForegroundColor = ConsoleColor.Green
        ingegevenMaand = Console.ReadLine
        Console.ForegroundColor = ConsoleColor.Gray
        Do While ingegevenMaand > 12
            Console.Write("Maand in 2014? (1-12): ")
            Console.ForegroundColor = ConsoleColor.Green
            ingegevenMaand = Console.ReadLine
            Console.ForegroundColor = ConsoleColor.Gray
        Loop
        ingegevenMaand = ingegevenMaand - 1

        Console.Write("Dag in " & maanden(ingegevenMaand) & "? (1 - " & dagen(ingegevenMaand) & ")")

        Dim ingegevenDag As Integer
        Console.ForegroundColor = ConsoleColor.Green
        ingegevenDag = Console.ReadLine
        Console.ForegroundColor = ConsoleColor.Gray
        Do While ingegevenDag > dagen(ingegevenMaand)
            Console.Write("Dag in " & maanden(ingegevenMaand) & "? (1 - " & dagen(ingegevenMaand) & ")")
            Console.ForegroundColor = ConsoleColor.Green
            ingegevenDag = Console.ReadLine
            Console.ForegroundColor = ConsoleColor.Gray
        Loop

        Dim totaalDagen As Integer

        For i = 0 To ingegevenMaand
            totaalDagen = maanden(i)
            Console.WriteLine(totaalDagen)
        Next







        Console.ReadLine()
    End Sub

End Module
