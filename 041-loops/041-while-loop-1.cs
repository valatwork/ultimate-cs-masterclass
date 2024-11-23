/* 
while (Boolean expression)
{
    statements
}
- the condition is tested before the loop runs
- statements will get executed as long as long as the expression is true
- braces are required if more than one statement must be executed
- infinite loops!

*/

NumLoop1(); 
NumLoop2();
// InfNumLoop();
NumLoop3();
Console.ReadKey();
void NumLoop1()
{
    var number = 0;
    while (number < 10)
    { 
        number = number + 1;
        Console.WriteLine("The number is: " + number);
    }
    
    Console.WriteLine("Loop #1 is finished.");
}

void NumLoop2()
{
    var number = 0;
    while (number < 10)
    {
        number += 1;
        Console.WriteLine("The number is: " + number);
    }

    Console.WriteLine("Loop #2 is finished.");
}

void NumLoop3()
{
    var number = 0;
    while (number < 10)
    {
        number++;
        Console.WriteLine("The number is: " + number);
    }
    
    Console.WriteLine("Loop #3 is finished.");
}

// void InfnumLoop()
// {
    //     var number = 0;
    //     while (number < 10)
    //     {
    //         number *= 2;
    //         Console.WriteLine("The number is: " + number);
    //     }

    //     Console.WriteLine("The loop is finished.");

    // }
// }



