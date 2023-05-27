// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// using System;

// class Program {
//     static int PositiveNum(int[] numbers, int size) {
//         int count = 0;
//         for (int i = 0; i < size; i++) {
//             if (numbers[i] > 0) {
//                 count++;
//             }
//         }
//         return count;
//     }

//     static int[] CreateRandomArray(int size, int minValue, int maxValue) {
//         int[] newArray = new int[size];
//         for (int i = 0; i < size; i++) {
//             newArray[i] = new Random().Next(minValue, maxValue + 1);
//         }
//         return newArray;
//     }

//     static void PrintArray(int[] array) {
//         for (int i = 0; i < array.Length; i++) {
//             Console.Write(array[i] + " ");
//         }
//         Console.WriteLine();
//     }

//     static void Main(string[] args) {
//         Console.WriteLine("Input array size ");
//         int size = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Input minimal value of element ");
//         int minValue = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Input maximal value of element ");
//         int maxValue = Convert.ToInt32(Console.ReadLine());

//         int[] array = CreateRandomArray(size, minValue, maxValue);
//         PrintArray(array);

//         int count = PositiveNum(array, size);
//         Console.WriteLine($"{count} - количество чисел больше 0");
//     }
// }

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Введите значение b1: ");
        double b1 = double.Parse(Console.ReadLine());
        Console.Write("Введите значение k1: ");
        double k1 = double.Parse(Console.ReadLine());
        Console.Write("Введите значение b2: ");
        double b2 = double.Parse(Console.ReadLine());
        Console.Write("Введите значение k2: ");
        double k2 = double.Parse(Console.ReadLine());

        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;

        Console.WriteLine($"Точка пересечения прямых: ({x}; {y})");
    }
}