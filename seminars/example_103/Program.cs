// from -number to +number
System.Console.WriteLine("Enter your number");
int positiveNumber = Convert.ToInt32(Console.ReadLine()); // N
if (positiveNumber < 0) positiveNumber*= -1; // Из отр -> пол.
int negativeNumber = positiveNumber * (-1); // -5 = 5 * (-1), -N

while (negativeNumber <= positiveNumber) // пока условие истинно
{
    Console.WriteLine(negativeNumber);
    negativeNumber++;  // negativeNumber = negativeNumber + 1
    // negativeNumber+=1
}
