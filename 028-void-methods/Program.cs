//Console.WriteLine("See all TODOs");
//Console.WriteLine("Add a TODO");
//Console.WriteLine("Remove a TODO");
//Console.WriteLine("Exit");


var userChoice = Console.ReadLine();

/*
if (userChoice == "S")
{
    Console.WriteLine("Selected option: See all TODOs");
}
else if (userChoice == "A")
{
    Console.WriteLine("Selected option: Add a TODO");
}
else if (userChoice == "R")
{
    Console.WriteLine("Selected option: Remove a TODO");
}
else if (userChoice == "E")
{
    Console.WriteLine("Selected option: Exit");
}

Console.ReadKey();

*/


// a void method only prints on the console and doesn't return anything
void PrintSelectedOption(string selectedOption)
{
    Console.WriteLine("Selected option: " + selectedOption);
}


if (userChoice == "S")
{
    PrintSelectedOption("See all TODOs");
}
else if (userChoice == "A")
{
    PrintSelectedOption("Add a TODO");
}
else if (userChoice == "R")
{
    PrintSelectedOption("Remove a TODO");
}
else if (userChoice == "E")
{
    PrintSelectedOption("Exit");
}

Console.ReadKey();
