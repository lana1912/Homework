//21.ПРОГРАММА ПРОВЕРЯЕТ ПЯТИЗНАЧНОЕ ЧИСЛО НА ПАЛИНДРОМОМ.
void A(int number)
{
int h=number/10000;
int b= number/1000%10;
int c= number/10%10;
int d=number%10;

if((h==d)&(b==c))
{
  Console.Write($"Число: {number} является палиндромом");
}
else{
  Console.Write($"Число {number} не является палиндромом");

}
}
int number=new Random().Next(10000,100000);
Console.WriteLine(number);
A(number);