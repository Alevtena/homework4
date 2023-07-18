// Task 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
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

int SumDigits(int n)
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