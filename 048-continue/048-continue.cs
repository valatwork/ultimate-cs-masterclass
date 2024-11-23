Continue01();
Continue02();
Continue03();
Continue04();

void Continue01()
{
    for(var i = 0; i < 20; ++i)
    {
        Console.WriteLine("i is " + i);
    }
    Console.WriteLine("Continue01 loop finished");
}

void Continue02()
{
    for(var i = 0; i < 20; ++i)
    {
        if (i % 3 == 0)
        {
            continue;
        }
        Console.WriteLine("i is " + i);
    }
    Console.WriteLine("Continue02 loop finished");
}

void Continue03()
{
    for(var i = 0; i < 20; ++i)
    {
        if (i % 3 != 0)
        {
            continue;
        }
        Console.WriteLine("i is " + i);
    }
    Console.WriteLine("Continue03 loop finished");
}

void Continue04()
{
    int userNumber;
    do
    {
        Console.WriteLine("Enter a number greater than 10");
        var userInput = Console.ReadLine();

        if (userInput == "stop")
        {
            break;
        }
        bool isParsableToInt = userInput.All(char.IsDigit);
        if (!isParsableToInt)
        {
            userNumber = 0;
            continue;
        }
        
        userNumber = int.Parse(userInput);   
    } while (userNumber <= 10);
    
    Console.WriteLine("Continue04 loop finished");
}
