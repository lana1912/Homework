//10.ПОКАЗАТЬ ВТОРУЮ ЦИФРУ ТРЕХЗНАЧНОГО ЧИСЛА.

void number(int C)
{
    int A=C%100/10;
    Console.WriteLine(A);
}
int C=new Random().Next(100,999);
Console.WriteLine(C);
number(C);

