//04.НАЙТИ МАКСИМАЛЬНОЕ ИЗ ТРЕХ ЧИСЕЛ.

  void number(int A, int B, int C)
{
    int max=0;
    A= max;
    if(B>A) {max=B;}
    if(C>B) {max=C;}
    Console.Write($"Максимальное из трех чисел: {max}");
}
Console.WriteLine("Введите число A : ");
 int A=Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите число B : ");
 int B=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C : ");
 int C=Convert.ToInt32(Console.ReadLine());
number(A,B,C); 