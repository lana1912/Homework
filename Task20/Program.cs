//20.ВВЕСТИ НОМЕР ЧЕТВЕРТИ, ПОКАЗАТЬ ДИАПОЗОНЫ ДЛЯ ВОЗМОЖНЫХ КООРДИНАТ 

 string A(int b)
{
  string res=string.Empty;
  if (b==1)
  {
    res=$"(0, {int.MaxValue},0,{int.MaxValue})";
    Console.WriteLine(res);
  }
  if(b==2)
  {
    res=$"({int.MinValue},0,0,{int.MinValue})";
    Console.WriteLine(res);
  }
  if(b==3)
  {
    res=$"({int.MinValue},0, {int.MinValue}, 0)";
    Console.WriteLine(res);
  }
  if(b==4)
  {
    res=$"(0, {int.MaxValue},{int.MaxValue},0)";
    Console.WriteLine(res);
  }
  return res;
}
Console.WriteLine("Введите четверть : ");
int b=Convert.ToInt32(Console.ReadLine());
A(b);
