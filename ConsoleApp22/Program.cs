using Solid;
Сalculator сalculator = new Сalculator();
double areaT = сalculator.calculateAreaCircle(3);
double areaC = сalculator.calculateAreaTriangle(3,2,2);

Console.WriteLine("{0}, {1}",areaT, areaC);