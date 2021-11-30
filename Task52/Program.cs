//52.В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
void Matrix(int [,] a)
{
    for(int i=0; i<a.GetLength(0); i++)
    {
        for(int j=0; j<a.GetLength(1); j++)
        {
           a[i,j]= new Random().Next(10,50);
           Console.Write($"{a[i,j]} ");
        }
        Console.WriteLine();
    }
}

void Square (int [,] a)
{
    for(int i=0; i<a.GetLength(0); i++)
    {
        for(int j=0; j<a.GetLength(1); j++)
        {
            if((i%2==0)&(j%2==0))
            {
                a[i,j]=a[i,j]*a[i,j];
        
            }
           Console.Write($"{a[i,j]} ");
        }
        Console.WriteLine();
    }
}

int [,] a= new int [6,6];
Matrix(a);
Console.WriteLine();
Square(a);
