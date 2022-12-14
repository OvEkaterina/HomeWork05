// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
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
void Difference(int[] array)
{
    int size = array.Length;
    int max = array[0];
    int min = array[1];
       for (int i = 0; i < size; i++)
    {
        if (array[i] > max) max = array[i];
        else
        {
            if (array[i] < min) min = array[i];   
        }                          
    }
    Console.WriteLine($"[{string.Join(",", array)}] -> {max-min}");
}
int[] array = createdMassive(6, 1, 20);
Difference(array);