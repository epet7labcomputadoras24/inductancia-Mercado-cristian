Module Module1

    Sub Main()
        Dim B1 As Single
        Dim B2 As Single
        Dim h As Single
        Dim A As Single
        Console.Write("intruduzca la base menor:")
        B1 = Console.ReadLine()
        Console.Write("intruduzca la base mayor:")
        B2 = Console.ReadLine()
        Console.Write("intruduzca la altura:")
        h = Console.ReadLine()
        A = (B1 + B2) * (h / 2)
        Console.WriteLine("el area del trapecio es:" & A)
        Console.ReadLine()
    End Sub

End Module
