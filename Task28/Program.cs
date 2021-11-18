int sum(int number)
{
int h=number/10000;
int b= number/1000%10;
int n=number/100%10;
int c= number/10%10;
int d=number%10;
    int A=h+b+n+c+d;
    Console.WriteLine(A);
    return A;
}
Console.WriteLine("Введите число : ");
int number=Convert.ToInt32(Console.ReadLine());
sum(number);
