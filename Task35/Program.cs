// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. Найдите количество 
// элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] array = new int[123];
Random r = new Random();
int number = 0;

for (int i = 0; i < array.Length; i++)
{
array[i] = r.Next(0, 151);
if (array[i]<100 && array[i]>9)
{
    number++;
}
}
// Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99] = {number}");