
Console.WriteLine("Hello, World!");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine();

void PrintSelectedOption(string selectedOption)
{
    Console.WriteLine("Selected option: " + selectedOption);
}

/*switch (userChoice)
{
    case "S":
        PrintSelectedOption("See all TODOs");
        break;
    case "A":
        PrintSelectedOption("Add a TODO");
        break;
    case "R":
        PrintSelectedOption("Remove a TODO");
        break;
    case "E":
        PrintSelectedOption("Exit");
        break;
}

Console.ReadKey();*/

switch (userChoice)
{
    case "S":
        PrintSelectedOption("See all TODOs");
        break;
    case "A":
    case "a":
        PrintSelectedOption("Add a TODO");
        break;
    case "R":
        PrintSelectedOption("Remove a TODO");
        break;
    case "E":
        PrintSelectedOption("Exit");
        break;
    default: Console.WriteLine("Invalid choice");
        break;
}

Console.ReadKey();


/*string ConvertPointsToGrade(int points)
{
    string result;
    switch(points)
    {
        case 10:
        case 9:
            result = "A";
            break;
        case 8:
        case 7: 
        case 6:
            result = "B";
            break;
        case 5: 
        case 4:
        case 3: 
            result = "C";
            break;
        case 2:
        case 1:  
            result = "D";
            break;
        case 0:
            result = "E";
            break;
        default:
            result = "!";
            break;

    }
    return result;
}*/


string ConvertPointsToGrade(int points)
{
    string result;
    switch (points)
    {
        case 10:
        case 9:
            return "A";
        case 8:
        case 7:
        case 6:
            return "B";
        case 5:
        case 4:
        case 3:
            return "C";
        case 2:
        case 1:
            return "D";
        case 0:
            return "E";
        default:
            return "!";
    }
}

char ConvertPointsToGrade(int points)
{
    switch (points)
    {
        case 10:
        case 9:
            return 'A';
        case 8:
        case 7:
        case 6:
            return 'B';
        case 5:
        case 4:
        case 3:
            return 'C';
        case 2:
        case 1:
            return 'D';
        case 0:
            return 'E';
        default:
            return '!';
    }
}    