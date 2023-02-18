// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int InputInt(string message) // ввод с консоли значение, возвращаем целое число
{
    System.Console.Write($"{message} > ");
    int value;
    if (int.TryParse(Console.ReadLine(), out value)) // проверка правильности ввода
    {
        return value;
    }
    System.Console.WriteLine("Ошибка. Введено не целочисленное значение");
    Environment.Exit(1);
    return 0;
}

(int x, int y, int z) GetPointCoords(string message) // вывод координат точки в виде кортежа
{
    System.Console.WriteLine($"{message}");
    int x = InputInt("X");
    int y = InputInt("Y");
    int z = InputInt("Z");
    return(x, y, z);
}

double Distance((int x, int y, int z) point1, (int x, int y, int z) point2) // вычисление диагонали прямоугольного палаллелепипеда
{
    double dist = Math.Sqrt(Math.Pow((point2.x - point1.x), 2) + Math.Pow((point2.y - point1.y), 2) + Math.Pow((point2.z - point1.z), 2)); 
    return dist;
}

var pointA = GetPointCoords("Введите пространственные координаты точки A");
var pointB = GetPointCoords("Введите пространственные координаты точки B");

System.Console.WriteLine($"Расстояние между указанными точками составляет {Distance(pointA, pointB):f2}");