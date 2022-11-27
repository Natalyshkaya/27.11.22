// Напишите программу, которая принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. 
// Для решения задания использование цикла for является обязательным условием. 
// Не использовать встроенный метод возведения в степень.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Step(int NumberOne, int NumberTwo)
{
    int result = 1;
    for (int i = 1; i <= NumberTwo; i++ )
    {
        result = result * NumberOne;
    }
    return result;
}


Console.Write("Введите первое число: ");
int NumberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int NumberTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{NumberOne}^{NumberTwo}={Step(NumberOne, NumberTwo)}");
