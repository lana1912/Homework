//13.ВЫЯСНИТЬ, КРАТНО ЛИ ЧИСЛО ЗАДАННОМУ, ЕСЛИ НЕТ, ВВЫВЕСТИ ОСТАТОК.

void number (int A, int B)
{
int C=0;
if(B%A==0){Console.WriteLine("Число В кратно числу А");}
else{C=B%A; Console.WriteLine($"Остаток от деления {C}");} 
}
Console.WriteLine("Введите число A : ");
int A=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B : ");
int B=Convert.ToInt32(Console.ReadLine());
number(A, B);