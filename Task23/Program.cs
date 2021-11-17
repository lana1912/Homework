//23.ПОКАЗАТЬ ТАБЛИЦУ КВАДРАТОВ ЧИСЕЛ ОТ 1 ДО N.
 void Method(int N)
{
  for(int count=1;count<=N;count++)
  {
    Console.WriteLine($"Квадварт числа {count}={count*count}");
  }
}
Console.Write("Введите число: ");
int N=Convert.ToInt32(Console.ReadLine());
Method(N); 
