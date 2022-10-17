// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// Внутренние функции использовать нельзя(Max и Min)
// [3 7 22 2 78] -> 76


void InputArray(double[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = Convert.ToDouble(Console.ReadLine());
}

double difference(double[] array)
{
    double max = 0;
    double min = array[0];
    double result = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
        result = max - min;
        return result;
}
Console.Clear();
Console.WriteLine("Введите массив: ");
double[] array = new double[10];
InputArray(array);
Console.WriteLine($"Начальнаый массив: [{string.Join(", ", array)}]");
difference(array);
Console.WriteLine($"Результат: {difference(array)}");
