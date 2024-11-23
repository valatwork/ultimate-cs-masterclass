BreakLoop001();
BreakLoop002();
BreakLoop003();

void BreakLoop001()
{ for (var i = 0; i < 100; i++)
    {
        Console.WriteLine("i is " + i);
        if (i > 25)
        {
            break;
        }
    }
    
}

void BreakLoop002()
{
    int userNumber;
    do
    {
        Console.WriteLine("Enter a number larger than 20: ");
        var userInput = Console.ReadLine();
        userNumber = int.Parse(userInput);
    } while (userNumber <= 20);
}

void BreakLoop003()
{
    int userNumber;
    do
    {
        Console.WriteLine("Enter a number larger than 10: ");
        var userInput = Console.ReadLine();

        if (userInput == "stop")
        {
            break;
        }
        userNumber = int.Parse(userInput);
    } while (userNumber <= 10);
}

Console.ReadKey();
