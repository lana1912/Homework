//51.Задать двумерный массив следующим правилом: Aₘₙ = m+n

void Matrix(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = i + j;
            Console.Write($"{a[i, j]} ");

        }
        Console.WriteLine();
    }
}
int[,] a = new int[4, 5];
Matrix(a);

