//03.ПО ЗАДАНОМУ НОМЕРУ ДНЯ ВЫВЕСТИ ДЕНЬ НЕДЕЛИ.

 string Method(int a)
{
    string [] days={"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота","Воскресенье"};
    string b = Convert.ToString(days[a-1]);

    
    return b;

}
Console.Write("Введите день недели: ");
int a = Convert.ToInt16(Console.ReadLine());
Console.Write(Method(a)); 
  
