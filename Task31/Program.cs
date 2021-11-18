//31.СОЗДАТЬ МАССИВ ИЗ 8 ЭЛЕМЕНТОВ, ВЫВЕСТИ МАССИВ.
void number (int [] C)
{
for(int i=0;i<C.Length;i++)
{
    C[i]=new Random().Next(50);
    Console.Write($" {C [i] } ");
}
}
int [] C = new int [8];
number(C);

