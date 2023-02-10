Console.WriteLine("Введите коэффициент K1");
double numbK1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите коэффициент B1");
double numbB1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите коэффициент K2");
double numbK2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите коэффициент B2");
double numbB2 = double.Parse(Console.ReadLine()!);

Console.WriteLine($" Первая прямая выражается уравнением: Y={numbK1}*x+{numbB1}");
Console.WriteLine($" Вторая прямая выражается уравнением: Y={numbK2}*x+{numbB2}");
double x=0;
double y=0;
if (numbK1==numbK2)
{
    Console.WriteLine("Прямые не имеют точек пересечения так как параллельны друг другу");
}
else
{
    x=(numbB2-numbB1)/(numbK1-numbK2);
    y=numbK1*x+numbB1;
    Console.WriteLine($"Прямые пересекаются в точке с координатами: X= {x} Y = {y}");
}
