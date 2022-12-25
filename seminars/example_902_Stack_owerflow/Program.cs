string SayHello()
{
    Console.WriteLine("Hi");
    return SayHello();
}

Console.WriteLine(SayHello());
