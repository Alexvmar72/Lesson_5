/* Задача 34: 

   Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2                   */

Console.Clear();

int Prompt(string message)
{
    Console.Write(message);
    int num_result = int.Parse(Console.ReadLine()!);
    return num_result;
}

int[] GetBinaryArray(int len, int min_pos, int max_pos)
{
    int[] arr_result = new int[len];
    for (int j = 0; j < len; j++)
    {
        arr_result[j] = new Random().Next(min_pos, max_pos + 1);
    }
    return arr_result;
}

int SumEven(int[] array)
{
    int len_2 = array.Length;
    int sum = 0;
    foreach (int item in array)
    {
        if (item % 2 == 0) sum++;
    }
    return sum;
}

int len = Prompt("Введите размер массива: ");
int min_pos = Prompt("Введите минимальное значение массива: ");
int max_pos = Prompt("Введите максимальное значение массива: ");
int[] table = GetBinaryArray(len, min_pos, max_pos);
//int sum_even = SumEven(table);

Console.WriteLine($"[{string.Join(", ", table)}] -> {SumEven(table)}");