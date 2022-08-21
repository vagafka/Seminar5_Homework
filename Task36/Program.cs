﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] array = new int[10];
Random r = new Random();
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
array[i] = r.Next(0, 10);
if(i%2==1)
{
    sum = sum + array[i];
}
}

Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях = {sum}");