void Array (int [] a)
{
    for(int i=0;i<a.Length;i++)
    {
        a[i]=new Random().Next(1,10);
        Console.Write($" {a[i]} ");

    }
}
Console.WriteLine("Одномерный массив");
int [] a=new int [7];
Array(a);
Console.WriteLine();

void Product(int [] a) 
{ 
    int j = a.Length-1; 
    int count = a.Length/2; 
    for(int i =0;  i <count; i++) 
    { 
         
            Console.WriteLine($"{a[i]} * {a[j]} = {a[i] * a[j]}"); 
            j--;            
         
    } 
} 
Product(a);