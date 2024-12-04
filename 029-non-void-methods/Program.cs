var userChoice = Console.ReadLine();
bool isLong = IsLong(userChoice);

bool IsLong(string input)
{
    return input.Length > 10;
}

var result = Add(10, 5);
Console.WriteLine("10 + 5 = " + result);

int Add(int a, int b)
{
    return a + b;
}

//bool IsLong(string input)
//{
//    //if (input.Length > 10)
//    //{
//    //    return true;
//    //}
//    //return false;
//}

/*
 Define the AbsoluteOfSum method, which takes two int parameters, and returns the absolute value of their sum.
 */
static int AbsoluteSumA(int a, int b)
{
    var sum = a + b;
    if (sum >= 0)
    {
        return sum;
    }
    return -sum;
}

static int AbsoluteSumB(int c, int d)
{
    return Math.Abs(c + d);
}