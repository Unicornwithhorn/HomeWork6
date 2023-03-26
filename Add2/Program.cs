// По целочисленным координатам вершин треугольника (x1,y1), (x2,y2) и (x3,y3) требуется вычислить его площадь.
// double x1 = new Random().Next(-999999,1000000);
// double x2 = new Random().Next(-999999,1000000);
// double x3 = new Random().Next(-999999,1000000);
// double y1 = new Random().Next(-999999,1000000);
// double y2 = new Random().Next(-999999,1000000);
// double y3 = new Random().Next(-999999,1000000);

double x1 = new Random().Next(-100,100);
double x2 = new Random().Next(-100,100);
double x3 = new Random().Next(-100,100);
double y1 = new Random().Next(-100,100);
double y2 = new Random().Next(-100,100);
double y3 = new Random().Next(-100,100);

double AB = Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2));
double BC = Math.Sqrt(Math.Pow(x3-x1,2)+Math.Pow(y1-y3,2)); 
double AC = Math.Sqrt(Math.Pow(x2-x3,2)+Math.Pow(y2-y3,2));
// double square = AC;
double square = AC * AB * Math.Sqrt(1 - Math.Pow((Math.Pow(AB, 2) + Math.Pow(AC, 2) - Math.Pow(BC, 2))/(2 * AB * AC), 2))/2;
// высота = AB * (Math.Sqrt(1 - Math.Pow(( Math.Pow(AВ, 2) + Math.Pow(AС, 2) - Math.Pow(BC, 2))/(2 * AВ * AС), 2)));

// double sin = Math.Sqrt(1 - Math.Pow(( Math.Pow(AВ, 2) + Math.Pow(AС, 2) - Math.Pow(BC, 2))/(2 * AВ * AС), 2));

System.Console.WriteLine($"x1 = {x1}, y1 = {y1}, x2 = {x2}, y2 = {y2}, x3 = {x3}, y3 = {y3}");
System.Console.WriteLine(Math.Round(square,2));
