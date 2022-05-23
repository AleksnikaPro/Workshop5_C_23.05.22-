// 1 Выяснить являются ли три числа сторонами треугольника

/*Console.Write("Введите 1 сторону треугольника: ");
int Side1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите 2 сторону треугольника: ");
int Side2 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите 3 сторону треугольника: ");
int Side3 = int.Parse(Console.ReadLine() ?? "0");

if ((Side1+Side2) > Side3 && (Side1+Side3) > Side2 && (Side2+Side3) > Side1)
    Console.WriteLine ("Являются сторонами треугольника");
else
    Console.WriteLine ("НЕ являются сторонами треугольника");*/


// вариант 2
???Console.Clear();
System.Console.WriteLine();

int A = 15;
int B = 25;
int C = 12;

bool triangle = (A + B > C && A + C > B && B + C > A);

if (triangle) System.Console.WriteLine("Из заданных отрезков можно составить треугольник");
else System.Console.WriteLine("Из заданных отрезков составить треугольник невозможно");