UserChoice001();
UserChoice002();
UserChoice003();

void UserChoice001()
{
    var userChoice = Console.ReadLine();

    if (userChoice.Length == 0)
    {
        Console.WriteLine("Empty choice!");
        int number = 5;
        Console.WriteLine(number);
        var word = "ABC";
        if (word.Length > 0)
        {
            Console.WriteLine(number);
            Console.WriteLine(userChoice);
        }
    }
    else
    {
        Console.WriteLine("Non-empty choice: " + userChoice);
    }

    Console.WriteLine("Your choice is: " + userChoice);
}


static void UserChoice002()
{
    var number = 100;
    if (number > 50)
    {
        var message = "Large number";
    }
    else if (number > 25)
    {
        var message = "Medium number";
    }
    else
    {
        var message = "Small number";
    }
}

void UserChoice003()
{
    string userChoice = Console.ReadLine();

    if (userChoice.Length == 0)
    {
        Console.WriteLine("Empty choice!");
        int number = 5;
        Console.WriteLine(number);
        var word = "ABC";
        if (word.Length > 0)
        {
            // var number = 10; number has already been declared in this scope
            Console.WriteLine(number);
            Console.WriteLine(userChoice);
        }
    }
    else
    {
        int number = 10; // this variable is in a different scope and can have a different value
        Console.WriteLine("Non-empty choice: " + userChoice);
    }

    Console.WriteLine("Your choice is: " + userChoice);
}