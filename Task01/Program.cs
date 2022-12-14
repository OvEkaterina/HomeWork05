// Задача 34Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
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
void EvenNumbers(int[] array)
{
    int size = array.Length;
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    Console.WriteLine($"[{string.Join(",", array)}] -> {count}");
   }
int[] array = createdMassive(4, 100, 999);
EvenNumbers(array);