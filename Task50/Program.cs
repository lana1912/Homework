//50.В двумерном массиве заменить четные элементы на противоположные.

void  Matrix(int [,] a )
{
    for(int i=0;i<a.GetLength(0); i++)
    {
        for(int j=0;j<a.GetLength(1); j++)
        {
            a[i,j]= new Random().Next(-5,20);
            Console.Write($"{a[i,j]} ");
        }
        Console.WriteLine();
    }
}

void Opposite(int [,] a)
{  
    int m=-1;
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1); j++)
        {
            if(a[i,j]%2==0)
            {
                a[i,j]=a[i,j]*m;

            }
            Console.Write($"{a[i,j]} ");
        }
        Console.WriteLine();
    }
}

int [,] a= new int [4,5];
Matrix(a);
Console.WriteLine();
Opposite(a);