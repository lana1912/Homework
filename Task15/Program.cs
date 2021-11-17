//15.ДАНО ЧИСЛО.ПРОВЕРИТЬ КРАТНО ЛИ ОНО 7 И 23.
 void number(int B)
{
  if(B%7==0) {Console.WriteLine("Число B кратно 7");}
  else{Console.WriteLine("Число B не кратно 7");}
  if(B%23==0) {Console.WriteLine("Число B кратно 23");}
  else{Console.WriteLine("Число B не кратно 23");}
}
Console.Write("Введите число В: ");
int B= Convert.ToInt16(Console.ReadLine());
number(B);
