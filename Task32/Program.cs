//32.СОЗДАТЬ МАССИВ ИЗ 8 ЭЛЕМЕНТОВ, ЗАПОЛНЕННЫХ 0 И 1. ВЫВЕСТИ НА ЭКРАН.
void number (int [] A)
{
  for(int i=0;i<A.Length;i++)
  {   
      A [i]=new Random().Next(2);
      Console.Write($" { A [ i ] }");
  }
}
int [] A= new int [8];
number(A);