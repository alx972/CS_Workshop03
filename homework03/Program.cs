// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

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

int number = InputInt("Введите значение N, до которого будем считать кубы чисел");

System.Console.Write("Результат: ");
for (int i = 1; i <= number; i++) // (1; 2; 3) инициализация; условия выполнения; шаг итерации
{
    System.Console.Write($"{Math.Pow(i, 3)} ");
}
System.Console.WriteLine();