// Задача 43: Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.
// 45 -> 101101; 3 -> 11 2 -> 10

/*string StringReverse(string inputString)
{
    char[] arr = inputString.ToCharArray();
    int size = arr.Length;
    char temp = arr[0];
    for (int i = 0; i < size; i++)
    {
        arr[i] = arr[size-i-1];
    }
    arr[size-1] = temp;
    return new string(arr);
}
 
string Dec2Bin(int decimalNumber)
{
    string binar = "";
    while ((decimalNumber) > 0)
    {
        binar = binar + decimalNumber % 2;
        decimalNumber = decimalNumber / 2;
    }
    return StringReverse(binar);
}

Console.WriteLine("Введите десятичное число");
string s = Console.ReadLine();
Console.WriteLine(s);
int deci = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Dec2Bin(deci));
*/

string s = Console.ReadLine();
Console.WriteLine(s);