//40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
void Array (double [] a)
{
    for(int i=0;i<a.Length;i++)
    {
        a[i]=new Random().Next(1,10);
    Console.Write($"{a[i]} ");
    }
}

double Diff(double [] a)
{
    double m=a.Max<double>();
    double n=a.Min<double>();
    double diffr=m-n;
    return diffr;
}
double [] a= new double [10];
Array(a);
Console.WriteLine();
Console.WriteLine("Разница между максимальным и минимальным элементом");
Console.WriteLine(Diff(a));
