/* Задача 36: 

   Задайте одномерный массив, 
заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0                 */

Console.Clear();

int Prompt(string message)
{
    Console.Write(message);
    int num_result = int.Parse(Console.ReadLine()!);
    return num_result;
}

int[] GetArray(int len, int min_pos, int max_pos)
{
    int[] arr_result = new int[len];
    for (int j = 0; j < len; j++)
    {
        arr_result[j] = new Random().Next(min_pos, max_pos + 1);
    }
    return arr_result;
}

int SumOdd(int[] array)
{
    int len_2 = array.Length;
    int sum = 0;
    for (int i = 1; i < len_2; i = i + 2) sum = sum + array[i];
    return sum;
}

int len = Prompt("Введите размер массива: ");
int min_pos = Prompt("Введите минимальное значение массива: ");
int max_pos = Prompt("Введите максимальное значение массива: ");
int[] table = GetArray(len, min_pos, max_pos);

Console.WriteLine($"[{string.Join(", ", table)}] -> {SumOdd(table)}");