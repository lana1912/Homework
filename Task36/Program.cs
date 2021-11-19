//36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
void number(int [] N)
{
    for(int i=0;i<N.Length;i++)
    {
        N[i]=new Random().Next(100,1000);
        Console.Write($" {N[i]} ");
    }
Console.WriteLine();
    int A=0;
    int B=0;
    for(int i=0;i<N.Length;i++)
    {
        if(N[i]%2==0)
        {
            A=A+1;
        }
        else
        {
            B=B+1;
        }
    }
    Console.Write($"Четных чисел {A}");
    Console.WriteLine();
    Console.Write($"Нечетных чисел {B}");
}
int [] N=new int [15];
number(N);