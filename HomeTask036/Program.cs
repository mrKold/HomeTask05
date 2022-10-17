// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(-10, 11);
}


int ReleaseArray(int[] array)
{
    int summaN = 0;
    for (int i = 1; i < array.Length; i+=2)
         summaN = summaN + array[i];
    return summaN;
}

Console.Clear();
int[] array = new int[10];
InputArray(array);
Console.WriteLine($"Начальнаый массив: [{string.Join(", ", array)}]");
ReleaseArray(array);
Console.WriteLine($"Результат: {ReleaseArray(array)}");