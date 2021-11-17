//07.ПОКАЗАТЬ ЧИСЛА ОТ - N ДО +N.
void number(int N)
{
 int minN= N*-1;
 int count=minN;
 while(count<=N)
 {
   Console.WriteLine(count);
   count++;
 } 
}
Console.Write("Введите число N: ");
int N=Convert.ToInt32(Console.ReadLine());
number(N);

