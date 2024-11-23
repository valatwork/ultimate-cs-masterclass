NestedLoop01();
NestedLoop02();

void NestedLoop01()
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 3; ++j)
        {
            Console.WriteLine($"i is {i}, j is {j} (NestedLoop01)");
        }
    }
}

void NestedLoop02()
{
    for(int a = 0; a < 4; ++a)
    {
        for(int b = 0; b < 3; ++b)
        {
           for(int c = 0; c <5; ++c)
           {
               Console.WriteLine($"a is {a}, b is {b}, c is {c}(NestedLoop02)");
           } 
        }
    }
}