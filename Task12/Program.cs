// Удалить вторую цифру трёхзначного числа

void number(int A)
{
    int number2 = A/100*10+A%10;
    Console.WriteLine(number2);
}
int A=new Random().Next(100,999);
Console.WriteLine(A);
number(A);