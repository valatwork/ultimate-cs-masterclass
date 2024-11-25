ForeachLoop01();
ForeachLoop02();
ForachExercise01();

void ForeachLoop01()
{
    var words = new [] {"one", "two", "three", "four"};

    for(var i = 0; i < words.Length; i++)
    {
        Console.WriteLine(words[i]);
    }
}

void ForeachLoop02()
{
    var words = new [] {"one", "two", "three", "four"};
    
    foreach (var word in words)
    {
        Console.WriteLine(word);
    }
}

void ForeachExercise01()
{
    bool IsAnyWordLongerThan(int length, string[] words)
    {
        foreach (var word in words)
        {
            if (word.Length > length)
            {
                return true;
            }
        }
        return false;
    }
}

 
