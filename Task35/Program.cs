//35. Определить, присутствует ли в заданном массиве, некоторое число.
void number(int [] N, int A)
{
    for(int i=0;i<N.Length;i++)
    {
        N[i]=new Random().Next(0,15);
        Console.Write($" {N[i]} ");
    }
    Console.WriteLine();
   for(int i=0;i<N.Length;i++)
   {
       if(N[i]==A)
       {   
           Console.WriteLine($"Число {A} есть в массиве");
    
       }
       else{A=-1;}
       
   }
   if(A==-1)
       {
           Console.WriteLine("Числа в массиве нет");
       }

}
int [] N=new int [10];
Console.WriteLine("Введите число  А : ");
int A=Convert.ToInt32(Console.ReadLine());
number (N, A);
