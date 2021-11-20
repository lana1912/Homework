//38. Найти сумму чисел одномерного массива стоящих на нечетной позиции.
void number(int [] N)
{
    for(int i=0;i<N.Length;i++)
    {
        N[i]=new Random().Next(0,50);
        Console.Write($" {N[i]} ");
    }

}
int [] N=new int [6];
number (N);
Console.WriteLine();
int sum(int [] N)
{
    int A=0;
    for(int i=0;i<N.Length;i++)
    {
        if(i%2!=0)
        {
            A=A+N[i];
        }
    }
    return A;
}
Console.WriteLine("Сумма чисел стаящих на нечетной позиции : ");
Console.Write(sum(N));

