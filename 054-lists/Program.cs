OnLists01();
OnLists02();
OnLists03();

void OnLists01()
{
    List<string> words = new List<string>();
    Console.WriteLine("The count of elements is " + words.Count);
}

void OnLists02()
{
    List<string> words = new List<string>();
    Console.WriteLine("The count of elements is " + words.Count);
    
    words.Add("Hello");
    Console.WriteLine("The count of elements is " + words.Count);
}

void OnLists03()
{
    var words = new List<string>
    {
        "one",
        "two",
    };
    Console.WriteLine("The count of the elements is " + words.Count);
    
    foreach(var word in words)
    {
        Console.WriteLine(word);
    }
}