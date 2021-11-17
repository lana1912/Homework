//01.ПО ДВУМ ЗАДАНЫМ ЧИСЛАМ ПРОВЕРЯТЬ ЯВЛЯЕТСЯ ЛИ ПЕРВОЕ КВАДРАТОМ ВТОРОГО.

void Method (int a, int b)
 {
     if (a==b*b) { Console.WriteLine($"Число a: {a} является квадратом числа b: {b}");}
     else {Console.WriteLine($"Число a:{a} не является квадратом числа b: {b}");}
 }
 Console.WriteLine("Введите число а : ");
 int a=Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите число b : ");
 int b=Convert.ToInt32(Console.ReadLine());
 Method (a,b); 
