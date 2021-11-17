//08.ПОКАЗАТЬ ЧЕТНЫЕ ЧИСЛА ОТ 1 ДО N.
void number(int N)
{
    int count=1;
while(count<=N)
{
  if(count%2==0)
  {
    Console.WriteLine(count);
  }
  count++;
}
}
Console.WriteLine("Введите число : ");
int N=Convert.ToInt32(Console.ReadLine());
number(N);
