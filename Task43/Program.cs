// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("Дана система из двух уравнений");
Console.WriteLine("Первое уравнение:   y = k1 * x + b1");
Console.WriteLine("Второе уравнение:   y = k2 * x + b2");
Console.WriteLine("Введите значение k1");
int k1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение b1");
int b1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение k2");
int k2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение b2");
int b2 = int.Parse(Console.ReadLine()!);

if (k1 == k2)
{
  if (b1 == b2) System.Console.WriteLine("Прямые совпадают");
  else System.Console.WriteLine("Прямые параллельны");
}
else
{
int x = (b2 - b1) / (k1 - k2);
int y = k1 * x + b1;
int ytest = k2 * x + b2;
System.Console.WriteLine($"Точка пересечения прямых, заданных этими уравнениями, имеет координаты {x}, {y}");
}