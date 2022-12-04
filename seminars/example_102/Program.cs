// Checking if 2nd number is square of the first one
Console.WriteLine("Enter 1st number");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 2st number");
int numberTwo = Convert.ToInt32(Console.ReadLine());
if (numberTwo == (numberOne * numberOne))
{
    Console.Write("2nd number IS square of the first one");
}
else
{
    Console.Write("2nd number IS NOT square of the first one");
}