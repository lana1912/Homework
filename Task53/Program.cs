//53.В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет.

void Matrix(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = new Random().Next(10, 22);
            Console.Write($"{a[i, j]} ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

string Number(int[,] a)
{
    string result = "Числа нет";
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            if (a[i, j] == n)
            {
                result = $"Позиция числа n - {i},{j}";

            }

        }
    }
    return result;
}

int[,] a = new int[3, 4];
Matrix(a);
Console.WriteLine();
Console.WriteLine(Number(a));

