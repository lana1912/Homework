//40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
Console.WriteLine("Введите сторону а");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону c");
int c = Convert.ToInt32(Console.ReadLine());

void triangle(int a, int b, int c)
{
    if((a+b>c) & (b+c>a) & (a+c>b))
    {
      Console.WriteLine("Числа являются сторонами треугольника");
    }
    else Console.WriteLine("Числа не являются сторонами треугольника");
}
triangle( a,  b,  c);