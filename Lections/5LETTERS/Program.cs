﻿/* Загадывается имя существительное в единственном числе именительном падеже.
И нужно это слово отгадать. Для этого ввести свое слово из 5 букв (тоже имя существительное в ед. числе, кроме тех случаев, когда оно в единств. числе не бывает(например, очки)). 
Если буква из введенного игроком слова есть в загаданном слове и стоит в том же месте - эта буква закрашивается  желтым фоном в введенном слове,
Если буква есть, но не на своем месте - белым фоном.
Если буквы нет - буква не выделяется.
Цель игры - за несколько попыток угадать загаданное слово.  */

using System;
using System.Linq;

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
int[] result = new int[5];
int[] victory = {2,2,2,2,2};
bool isEqual = Enumerable.SequenceEqual(result, victory);
for (int i = 0; i < 7; i++)
{
    Console.WriteLine("Введите слово из 5 букв! ->");
    string inputWord = Console.ReadLine();
    int lengthWord = inputWord.Length;
    for (int j = 0; j < lengthWord; j++)
    {
        result[j] = CheckWord(trueWord, inputWord[j], j);

    }
    Console.WriteLine(string.Join("", result));
    Console.WriteLine(string.Join("", victory));
    Console.WriteLine(isEqual);  
    if (isEqual == true) break;

}
