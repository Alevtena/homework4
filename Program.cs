﻿// Task 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/* int Stepen(int a, int b)
{
    int step = a;
    for( int i=1; i <=b-1; i++)
    step  = step*a;
    return step;
}
Console.Write("Input a number osnovanie stepeni"+" ");
int osnovanie = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number pokazatel stepeni"+" ");
int pokazatel = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Stepen(osnovanie, pokazatel));
*/

// Task 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

/* int SumDigits(int n)
{
    int sum = 0; 
    int count = 0;
    while (n>0)
    {
        int unit = n % 10;
        sum = sum + unit;
        n = n / 10 ;
        count++;
    }
    return sum;
}
Console.Write("Input a number"+" ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumDigits(number));
*/

// Task 3. Напишите программу, которая задаёт массив из m элементов и выводит их на экран. Разработать метод CreateArray(int size), генерирующий массив на основе данных, вводимых пользователем.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int InPut (string message) // метод ввода информации о массиве (его размер и ввод элементов массива)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int size)
{
    int[]array = new int [size];
    for(int i=0; i < size; i++)
    array[i] = InPut($"Введите число массива под индексом {i}");
    
    return array;

}

void ShowArray(int[] array)
{
    for(int i=0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();

}

int length = InPut ("Введите количество элементов в массиве");

int[] myArray  = CreateArray(length);
ShowArray(myArray);

