//48.Показать двухмерный массив размером m*n из целых чисел.
/* void PrintArray(int[,] matr)
{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            Console.Write($"{matr[m, n]} ");
        }
        Console.WriteLine();
    }
} */

void FillArray(int[,] matr)
{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            matr[m, n] = new Random().Next(10, 100);
            Console.Write($"{matr[m, n]} ");
        }
        Console.WriteLine();
    }
}
int[,] matrix = new int[3, 4];
FillArray(matrix);
//PrintArray(matrix);

