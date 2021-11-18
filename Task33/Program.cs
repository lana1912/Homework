//33. Задать массив из 12 элементов, заполненных числами из [-9,9]. Найти сумму положительных/отрицательных элементов массива
void number(int [] N)
{   
  int sum1=0;
  int sum2=0;
    for(int i=0;i<N.Length;i++)
    {
        N[i]= new Random().Next(-9,9);
        Console.Write($" { N [i] } ");
    }
    Console.WriteLine();
    for( int i=0;i<N.Length;i++)
        {
        
          if(N[i]>0)
          {
               sum1=sum1+N[i];
          }
          else 
          {
              sum2=sum2+N[i];

          }
        }
        Console.WriteLine($"Сумма положительных элементов {sum1}");
        Console.WriteLine($"Сумма отрицательных  элементов {sum2}");
}
int [] N= new int [12];
number (N);
