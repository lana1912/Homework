//05.Написать программу вычисления значения функции y=f(x).

int Function(int a)
{
    int y = a + 25 ;
    return y;
}
Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ваш ответ {Function(a)}");