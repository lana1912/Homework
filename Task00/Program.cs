//00.ВЫВЕСТИ КВАДРАТ ЧИСЛА 
 
 void Method(int b)
 {
   Console.WriteLine($"Квадрат числа b: {b*b}");
 }
 Console.Write("Введите число b : ");
 int b=Convert.ToInt32(Console.ReadLine());
 Method(b);
