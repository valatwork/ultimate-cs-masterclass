/* 
for (initialization; Boolean; iterator)
{
    statements
}
*/ 

ForLoop1();
FactorialLoop02();

Console.ReadKey();
return;

void ForLoop1()
{
    for (int i = 0; i < 5; ++i)
    {
        Console.WriteLine("Hello");
    }
    Console.WriteLine("The loop is finished");
}


/* FactorialLoop();
* function called without any arguments but requires one parameter (int number)
* 
 static int FactorialLoop(int number)
{
    int result = 1;
    for (int i = 1; i <= 5; ++i)
    {
        result *= i;
    }

    Console.WriteLine("Factorial is finished");
    
}*/


void FactorialLoop02()
{
    void ChooseFactorial()
    {
        Console.WriteLine("Enter a number to calculate its factorial:");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int number))
        {
            int result = Factorial(number);
            Console.WriteLine($"The factorial of {number} is {result}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }

        Console.ReadKey();
        
    }

    static int Factorial(int number)
    {
        int result = 1;
        for (int i = 1; i <= number; ++i)
        {
            result *= i;
        }

        Console.WriteLine("Factorial is finished");
        return result;
    }
    
    ChooseFactorial();
}