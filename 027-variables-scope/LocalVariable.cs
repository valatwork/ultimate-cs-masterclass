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