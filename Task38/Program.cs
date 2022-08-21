// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

// [3 7 22 2 78] -> 76

double[] array = new double[10];
Random r = new Random();
double max = array[0];
double min = double.MaxValue; // при приравнивании к элементу массива с нулевым индексом min всегда получался равным 0, поэтому прога нормально не работала. Пришлось его перезаписать
double result = 0;
Console.WriteLine(min);
Console.WriteLine(max);

for (int i = 0; i < array.Length; i++)
{
array[i] = r.NextDouble()*100;
if (array[i]>max)
{
    max = array[i];
    
}
if (array[i]<min)
{
    min = array[i];
    
}
}
result = max-min;
Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Максимальный элемент массива = {max}");
Console.WriteLine($"Минимальный элемент массива = {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {result}");