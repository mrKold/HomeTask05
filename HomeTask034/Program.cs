﻿// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2


void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(100, 1000);
}

int Numbers(int[] array)
{
    int P = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            P = P + 1;
    }
    return P;
}
Console.Clear();
int[] array = new int[5];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Numbers(array);
Console.WriteLine($"Результат: {Numbers(array)}");