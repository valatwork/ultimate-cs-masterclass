OnArrays01();
OnArrays02();
OnArrays03();
OnArraysRefract03();
OnArraysInit03();
OnArraysIter01();

void OnArrays01()
{
    int[] numbers = new int[3];
    Console.WriteLine("Element at index 0 is " + numbers[0]);
    Console.WriteLine("Element at index 1 is " + numbers[1]);
    Console.WriteLine("Element at index 2 is " + numbers[2]);
}

void OnArrays02()
{
    int[] numbers = new int[3];
    numbers[0] = 5;
    numbers[1] = 6;
    numbers[2] = 7;
    Console.WriteLine("Element at index 0 is " + numbers[0]);
    Console.WriteLine("Element at index 1 is " + numbers[1]);
    Console.WriteLine("Element at index 2 is " + numbers[2]);

    numbers[1] = 66;
    Console.WriteLine("Element at index 0 is " + numbers[0]);
    Console.WriteLine("Element at index 1 is " + numbers[1]);
    Console.WriteLine("Element at index 2 is " + numbers[2]);
}

void OnArrays03()
{
    int[] numbers = new int[5];
    numbers[0] = 5;
    numbers[1] = 6;
    numbers[2] = 7;
    numbers[3] = 17;
    numbers[4] = 22;
    var firstFromEnd = numbers[numbers.Length - 1];
    var secondFromEnd = numbers[numbers.Length - 2];
    Console.WriteLine("First from end is " + firstFromEnd);
    Console.WriteLine("Second from end is " + secondFromEnd);
}

void OnArraysRefract03()
{
    int[] numbers = new int[5];
    numbers[0] = 5;
    numbers[1] = 6;
    numbers[2] = 7;
    numbers[3] = 17;
    numbers[4] = 22;
    var firstFromEnd = numbers[^1];
    var secondFromEnd = numbers[^2];
    Console.WriteLine("First from end is " + firstFromEnd);
    Console.WriteLine("Second from end is " + secondFromEnd);
}

void OnArraysInit03()
{
    int[] numbers = new [] { 2, 6, 1, 6, 19 };
    var firstFromEnd = numbers[^1];
    var secondFromEnd = numbers[^2];
    Console.WriteLine("First from end is " + firstFromEnd);
    Console.WriteLine("Second from end is " + secondFromEnd);
}

void OnArraysIter01()
{
    int[] numbers = new int[] { 2, 6, 1, 6, 19 };
    
    var sum = 0;
    for(var i = 0; i < numbers.Length; ++i)
    {
        sum += numbers[i];
    }
    Console.WriteLine("The sum of the elements is " + sum);
}

Console.ReadKey();