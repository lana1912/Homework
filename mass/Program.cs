int [] a= new int [10];
for(int i =0; i<a.Length; i++)
{
    a[i]= new Random().Next(10);
    Console.Write($"{a[i]}");

}

int [] b= new int [a.Length];
Console.WriteLine("/n до ");
int index=0;
for(int i=0; i<a.Length; i++)
{
    if(a[i]%2==0)
    {
        b[index]=a[i];
        Console.Write($"{b[index]}");
        index++;
    }
}
Console.WriteLine("/n/n после");
for(int i=0; i<index; i++)
{
    Console.Write($"{b[i]}");
}
