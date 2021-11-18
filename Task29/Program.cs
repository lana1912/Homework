//29.ПРОИЗВЕДЕНИЕ ЧИСЕЛ ОТ 1 ДО N
int number (int N)
{
    int i=1;
    int v=1;
    for( i=1;i<=N;i++)
    {v=v*i;}
    Console.WriteLine(v);
    return i;
} 
Console.WriteLine("Введите число : ");
int N=Convert.ToInt32(Console.ReadLine());
number(N);