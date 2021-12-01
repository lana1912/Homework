//Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

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

void Number(int [,] a)
{   
    int sum=0;
    int j=0;
    for (int i=0; i<a.GetLength(1); i++)
    {
        sum=sum+a[i,j];
    }
    
}

int [,] a= new int[4,4];
Matrix(a);
Number(a);

