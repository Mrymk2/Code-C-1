    int a = 1;
    int b = 0;

    int n = 10;

    for (int i = 0; i < n; i++)
    {
        a = a + b;
        Console.WriteLine(a);
        Console.WriteLine(" ");
        b = a + b;
        Console.Write(b);
        Console.Write(" ");
    }
    Console.ReadKey();