/* Загадывается имя существительное в единственном числе именительном падеже.
И нужно это слово отгадать. Для этого ввести свое слово из 5 букв (тоже имя существительное в ед. числе, кроме тех случаев, когда оно в единств. числе не бывает(например, очки)). 
Если буква из введенного игроком слова есть в загаданном слове и стоит в том же месте - эта буква закрашивается  желтым фоном в введенном слове,
Если буква есть, но не на своем месте - белым фоном.
Если буквы нет - буква не выделяется.
Цель игры - за несколько попыток угадать загаданное слово.  */

int CheckWord(string compareWord, char letter, int position)
{
    int length = compareWord.Length;
    int guess = 0;
    if (letter == compareWord[position]) guess = 2;
    else
    {
        for (int i = 0; i < length; i++)
        {
            if (compareWord[i] == letter) guess = 1;
        }
    }
    return guess;
}
string trueWord = "поезд";
int result = 0;
while (result == 22222);
{
    Console.WriteLine("Введите слово из 5 букв! ->");
    string inputWord = Console.ReadLine();
    int lengthWord = inputWord.Length;
    for (int i = 0; i < lengthWord; i++)
    {
        result = CheckWord(trueWord, inputWord[i], i);
        Console.Write(result);
    }
}
