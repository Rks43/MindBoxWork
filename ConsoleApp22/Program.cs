using Solid;
Сalculator сalculator = new Сalculator();
double areaT = сalculator.calculateAreaCircle(3);
double areaC = сalculator.calculateAreaTriangle(3,2,2);
bool f = сalculator.checkSquareness(3, 4, 3);
if (f) Console.WriteLine("Прямоугольный");
else Console.WriteLine("Непрямоугольный");
Console.WriteLine("{0}, {1}",areaT, areaC);