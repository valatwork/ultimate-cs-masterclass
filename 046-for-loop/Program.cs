ForLoop1();
Factorial();

void ForLoop1()
{
    for (int i = 0; i < 5; ++i)
    {
        Console.WriteLine("Hello");
    }
    Console.WriteLine("The loop is finished");
}

static int Factorial(int number)
{
    int result = 1;
    for (int i = 1; i <= 5; ++i)
    {
        result *= i;
    }
    Console.WriteLine("Factorial is finished")
}

Console.ReadKey();