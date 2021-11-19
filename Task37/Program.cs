//37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
void number(int [] N)
{   
    int count=0;
    for(int i=0;i<N.Length;i++)
    {
        N[i]=new Random().Next(-50,200);
    } 

    for(int i=0;i<N.Length;i++)
    {
        if((N[i]>=10) & (N[i]<=99))
        {
           count++;
        }
    }
  Console.Write($"{count} элементов из отрезка [10,99] ");
}
int [] N= new int [123];
number(N);
