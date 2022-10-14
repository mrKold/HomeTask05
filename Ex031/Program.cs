//  Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
//  сумма отрицательных равна -20.

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
}

int SummaPositiveNumbers(int[] array)
{
    int summaP = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            summaP = summaP + array[i];
    }
    return summaP;
}
int SummaNegativeNumbers(int[] array)
{
    int summaN = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
            summaN = summaN + array[i];
    }
    return summaN;
}
Console.Clear();
int[] array = new int[12];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"Сумма положтельных чисел равна: {SummaPositiveNumbers(array)}");
Console.WriteLine($"Сумма отрицательных чисел равна: {SummaNegativeNumbers(array)}");