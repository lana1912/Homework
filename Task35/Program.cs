//35. Определить, присутствует ли в заданном массиве, некоторое число.
void number(int [] N)
{
    Console.WriteLine("Рандомный массив : ");
    for(int i=0;i<N.Length;i++)
    {
        N[i]=new Random().Next(0,15);
        Console.Write($" {N[i]} ");
    }
    Console.WriteLine();
  

}
int [] N=new int [12];
Console.WriteLine("Введите число  А : ");
int A=Convert.ToInt32(Console.ReadLine());
number (N);

string Find(int[] N)
{
     string result = "Числа нет ";
    for (int i = 0; i <N.Length; i++)
    {
         if (N[i] == A) result = "Число есть";
    }
    return result;
}
Console.WriteLine(Find (N));

