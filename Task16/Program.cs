string method(int a)
{
  string [] days= {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскреснье"};
  string b= Convert.ToString(days[a-1]);
  int c=6;
  int d=7;
  if (a==c) {Console.WriteLine("Выходной день");}
  if (a==d) {Console.WriteLine("Выходной день");}

  return b;
}
Console.Write("Введите день недели: ");
int a=Convert.ToUInt16(Console.ReadLine());
Console.Write(method(a)); 
