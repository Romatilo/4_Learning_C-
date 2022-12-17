bool IsTriangle(int a, int b, int c) // 3 стороны треугольника: а,b,c
{
    return (((a + b) > c) && ((a + c) > b) && ((b + c) > a));  // True, False
}

Console.WriteLine(IsTriangle(100000,3,4));
