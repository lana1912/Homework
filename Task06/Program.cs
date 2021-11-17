//06.Выяснить является ли число четным.

void Method(int a)
{
  if (a%2==0)
  {
    Console.WriteLine($"Число {a} четное");
  }
  else
  {
    Console.WriteLine($"Число {a} нечетное");
  }

}
Console.WriteLine("Введите число а : ");
int a=Convert.ToInt32(Console.ReadLine());
Method(a);

