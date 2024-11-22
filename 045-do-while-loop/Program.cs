WordLoop1();
WordLoop2();
WordLoop3();
    void WordLoop1()
    {
        string word;
        do
        {
            Console.WriteLine("Enter a word longer than 10 letters");
            word = Console.ReadLine();
        } while (word.Length <= 10);

        Console.WriteLine("The loop is finished");
        Console.ReadKey();
    }

    void WordLoop2()
    {
        string word = " ";
        while (word.Length <= 10)
        {
            Console.WriteLine("Enter a word longer than 10 letters");
            word = Console.ReadLine();
        }
        Console.WriteLine("The loop is finished");
        Console.ReadKey();
    }

    void WordLoop3()
    {
        string word = "12345";
        while (word.Length >= 3)
        {
            Console.WriteLine("Enter a word longer than 10 letters");
            word = Console.ReadLine();
        }
        Console.WriteLine("The loop is finished");
        Console.ReadKey();
    }