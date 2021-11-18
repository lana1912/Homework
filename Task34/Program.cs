//34. Написать программу замену элементов массива на противоположные.
void number (int [] N)
{
   for(int i=0;i<N.Length;i++)
   {
       N[i]=new Random().Next(-10,10);
       Console.Write($"{N[i]} ");
   }
   Console.WriteLine();
   for(int i=0;i<N.Length;i++)
   {   
    N[i]=N[i]*-1;
    Console.Write($" {N[i]} ");
   }
}
int [] N= new int [12];
number(N);