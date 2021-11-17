//14.НАЙТИ ТРЕТЬЮ ЦИФРУ ЧИСЛА ИЛИ СООБЩИТЬ ,ЧТО ЕЕ НЕТ.
void number(int A)
{
int C=A%10;
if(A/100>1) {Console.WriteLine(C);}
else {Console.WriteLine("Третьей цифры нет");}
}
Console.WriteLine("Введите число ");
int A=Convert.ToInt32(Console.ReadLine());
number(A);

