//19.ОПРЕДЕЛИТЬ НОМЕР ЧЕТВЕРТИ ПЛОСКОСТИ, В КОТОРОЙ НАХОДИТСЯ ТОЧКА С КООРДИНАТАМИ X И Y, ПРИЧЕМ X!=0 Y!=0
void number(double x, double y)
{
if((x>0) & (y>0)) {Console.WriteLine("Первая четверть");}
if((x<0) & (y>0)) {Console.WriteLine("Вторая четверть");}
if((x<0) & (y<0)) {Console.WriteLine("Третья четверть");}
if((x>0) & (y<0)) {Console.WriteLine("Четвертая четверть");}
}
double x=new Random().Next(-100,100);
Console.WriteLine(x);
double y=new Random().Next(-100,100);
Console.WriteLine(y);
number(x, y);
