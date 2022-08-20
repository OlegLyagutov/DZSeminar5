// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// Console.WriteLine("Введите размер массива:");
// int size = Convert.ToInt32(System.Console.ReadLine());
// int[] array = new int[size];
// int count = 0;
// for (int i = 0; i < size; i++)
// {
//     array[i] = new Random().Next(100,999);
//     if (array[i] % 2 == 0) count++;
// }
// Console.WriteLine($"[{String.Join("; ", array)}]");
// Console.WriteLine($"Количество чётных чисел в массиве: {count}");

// Задача 36: Задайте одномерный массив, заполненный случайными
//  числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// Console.WriteLine("Введите размер массива:");
// int size = Convert.ToInt32(System.Console.ReadLine());
// int[] array = new int[size];
// int sum = 0;
// for (int i = 0; i < size; i++)
// {
//     array[i] = new Random().Next(100);
// }
// Console.WriteLine($"[{String.Join("; ", array)}]");
// for (int i = 1; i < size; i = i + 2)
// sum = sum + array[i];
// Console.WriteLine($"Сумма элементов стоящих на нечётных позициях равна: {sum}");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу
//  между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// Вариант 1 ( ввод массива рандомно)

// Console.WriteLine("Введите размер массива:");
// int size = Convert.ToInt32(System.Console.ReadLine());
// double[] array = new double[size];
// double result = 0;
// for (int i = 0; i < size; i++)
// {
//     array[i] = new Random().Next(100);
// }
// Console.WriteLine($"[{String.Join("; ", array)}]");
// double max = array[0];
// double min = array[0];
// for (int i = 0; i < size; i++)
// {
//     if (array[i] > max) max = array[i];
//     if (array[i] < min) min = array[i];
//     result = max - min;
// }
// Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна: {result}");

// Вариант 2 (Ввод массива с консоли)

// Console.WriteLine("Введите размер массива:");
// int size = Convert.ToInt32(System.Console.ReadLine());
// double[] array = new double[size];
// double result = 0;
// for (int i = 0; i < size; i++)
// {
//     Console.WriteLine($"Введите {i+1} элемент:");
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine($"[{String.Join("; ", array)}]");
// double max = array[0];
// double min = array[0];
// for (int i = 0; i < size; i++)
// {
//     if (array[i] > max) max = array[i];
//     if (array[i] < min) min = array[i];
//     result = max - min;
// }
// Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна: {result}");
