//49.Показать двумерный массив размером m*n заполненный вещественными числами.


void FillArray(double [,] matr)
{
    for(double m=0; m<matr.GetLength(0); m++ )
    {
        for(double n=0; n<matr.GetLength(1); n++)
        {
            matr[m,n]=new Random().NextDouble(1,30);
        Console.Write($"{matr[m,n]}");

        }
        Console.WriteLine();
    }
}
double [,] matrix= new double [3,4];
FillArray (matrix);