/* Задача 38: 
   
   Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76                 */

Console.Clear();

double[] NewArray = { 3, 7, 22, 2, 78, 5, 12, 4 };

double DiffSearch(double[] array)
{
    double max = array[0];
    double min = array[0];
    foreach (double el in array)
    {
        if (el > max) max = el;
        if (el < min) min = el;
    }
    double result = max - min;
    return result;
}

Console.WriteLine($"[{string.Join(" ", NewArray)}] -> {DiffSearch(NewArray)}");