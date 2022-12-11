// Задача 31: Задайте массив из 12 элементов, заполненный 
// случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 
// 29, сумма отрицательных равна -20.

int[] GetArray(int size,int minValue, int maxValue)
 
{
    int[] array = new int[size]; //Массив на size элементов, заполненных нулями
    for (int i = 0; i < size; i++) // size = array.Length
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
// Вызов функции
/* int[] resultArray = GetArray(12, -9, 9);
Console.WriteLine(String.Join("; ", resultArray));

int resultPositive = 0; 
int resultNegative = 0; 
for (int i = 0; i < resultArray.Length; i++)
{
    if (resultArray[i] > 0) // положительное число
    {
        resultPositive += resultArray[i]; // resultPositive = resultPositive + resultArray[i]
    }

    else resultNegative += resultArray[i];
}



Console.WriteLine($"Сумма отр.чисел: {resultNegative}, сумма пол.чисел: {resultPositive}");
*/

for (int i = 0; i < resultArray.Length; i++)
{
    resultPositive += resultArray[i] > 0 ? resultArray[i] : 0;
    // resultArray[i] > 0 (ИСТИНА): resultPositive+=resultArray[i] 
    // resultArray[i] > 0 (ложь): resultPositive+=0
    resultNegative += resultArray[i] < 0 ? resultArray[i] : 0;
}
Console.WriteLine($"Сумма отр.чисел: {resultNegative}, сумма пол.чисел: {resultPositive}");