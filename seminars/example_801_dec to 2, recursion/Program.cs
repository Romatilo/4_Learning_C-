int number = 16;

void ToBinary (int number)
{
    if (number == 0) return;
    ToBinary(number / 2);
    Console.Write(number % 2);
} 

ToBinary(number);