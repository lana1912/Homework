 //02.ДАНЫ ДВА ЧИСЛА, ПОКАЗАТЬ НАИБОЛЬШЕЕ И НАИМЕНЬШЕЕ ЧИСЛО.

void Method (int a, int b)
{
    int max=0;
    int min=0;
  if(a>b) {max=a;min=b;}
  else{max=b; min=a;}
  Console.WriteLine($"Максимальное число {max}, минимальное число {min}");
}
Console.WriteLine("Введите число а : ");
 int a=Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите число b : ");
 int b=Convert.ToInt32(Console.ReadLine());
Method(a,b);