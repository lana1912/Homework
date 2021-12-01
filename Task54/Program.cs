//54.В матрице чисел найти сумму элементов главной диагонали

void Matrix(int [,] a)
{
    for(int i=0; i<a.GetLength(0); i++)
    {
        for(int j=0; j<a.GetLength(1); j++)
        {
            a[i,j]=new Random().Next(1,10);
            Console.Write($"{a[i,j]} ");
        }
        Console.WriteLine();
    }
}

int sum=0;

int Diagonal (int [,] a)
{
    for(int i=0; i<a.GetLength(0); i++)
    {
        for(int j=0; j<a.GetLength(1); j++)
        {
          if(i==j)
          {
              sum=sum+a[i,j];
          } 

        }
    }
   return sum;
}

int [,] a= new int [4,4];
Matrix(a);
Console.WriteLine("Сумма главной диагонали");
Console.WriteLine(Diagonal(a));
