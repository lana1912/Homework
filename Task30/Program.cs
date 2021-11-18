//30.ПОКАЗАТЬ КУБЫ ЧИСЕЛБ ЗАКАНЧИВАЮЩИХСЯ НА ЧЕТНУЮ ЦИФРУ.
int number(int N)
{
    int i=1;
    for ( i=1;i<=N;i++)
    {
        if (i%2==0)
        {
            Console.WriteLine($"Куб числа {i} = {i}*{i}*{i}");
        }
    
    }    
    return i;  
}
Console.WriteLine("Введите число : ");
int N=Convert.ToInt32(Console.ReadLine());
number (N);