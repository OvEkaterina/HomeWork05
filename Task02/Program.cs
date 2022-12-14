// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] createdMassive(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
    //  return Console.WriteLine($"[{string.Join(",",array)}]");
}
void SummUneven(int[] array)
{
    int size = array.Length;
    int summ = 0;
    for (int i = 0; i < size; i++)
    {
        if (i % 2 > 0) summ = summ + array[i];
    }
    Console.WriteLine($"[{string.Join(",", array)}] -> {summ}");
}
int[] array = createdMassive(6, 1, 20);
SummUneven(array);