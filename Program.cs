// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Stepen(int a, int b)
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

