// Задача 43: Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.
// 45 -> 101101; 3 -> 11 2 -> 10

string StringReverse(string inputString)  // Метод разворота строки
{
    char[] arr = inputString.ToCharArray();
    int size = arr.Length;
    char temp;
    for (int i = 0; i < size/2; i++)
    {
        temp = arr[i];
        arr[i] = arr[size-i-1];
        arr[size-i-1] = temp;
    }
    return new string(arr);
}
 
string Dec2Bin(int decimalNumber)           // метод перевода десятичного числа в двоичное
{
    string binar = "";
    while ((decimalNumber) > 0)
    {
        binar = binar + decimalNumber % 2;
        decimalNumber = decimalNumber / 2;
    }
    return StringReverse(binar);
}

Console.Write("Введите десятичное число: ");
int deci = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число в двоичном виде:    " + Dec2Bin(deci));