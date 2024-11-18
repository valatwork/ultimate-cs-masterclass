/* When the application starts, it shall print
Hello!
Input the first number
 */

Console.WriteLine("Hello!");
Console.WriteLine("Input the first number: ");
var userInputA = Console.ReadLine();
var numA = int.Parse(userInputA);

Console.WriteLine("Enter the second number: ");
var userInputB = Console.ReadLine();
var numB = int.Parse(userInputB);

Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");
var choice =  Console.ReadLine();

if (EqualsCaseInsensitive(choice, "A"))
{
    var sum = numA + numB;
    // Console.WriteLine(numA + "+" + numB + "=" + sum);
    PrinFinalEquation(numA, numB, sum, "+");
}
else if (EqualsCaseInsensitive(choice, "S"))
{ 
    var difference = numA - numB;
    PrinFinalEquation(numA, numB, difference, "-");
    // Console.WriteLine(numA + "-" + numB + "=" + difference);
}
else if (EqualsCaseInsensitive(choice, "M"))
{
    var multiplied = numA * numB;
    // Console.WriteLine(numA + "*" + numB + "=" + multiplied);
    PrinFinalEquation(numA, numB, multiplied, "*");
}
else
{
    Console.WriteLine("Invalid choice!");
}
Console.WriteLine("Press any key to exit.");
Console.ReadKey();

void PrinFinalEquation(int numA, int numB, int result, string @operator)
{
    Console.WriteLine(numA + " " + @operator + " " + numB + " = " + result);
}

bool EqualsCaseInsensitive(string left, string right)
{
    return left.ToUpper() == right.ToUpper();
}