void number(int N)
{
int B=N%10;
int C=N%100/10;
if(B>C) {Console.Write(B);}
if(C>B) {Console.Write(C);}
if(C==B){Console.Write(C);}
}
int N=new Random().Next(10,99);
Console.WriteLine(N);
number(N);
