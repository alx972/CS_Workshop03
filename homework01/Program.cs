// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Проверка без применения строк
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int howManyDigits = 5;

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

bool ValidateValue(int value) // проверка разрядности вводимого числа
{
// округляем вверх log10 введенного числа. Т.о. получаем количество знаков в числе, т.к. 10^x=b (lg 10=1, lg 100=2 и т.п.)
    int result = Convert.ToInt32(Math.Ceiling(Math.Log10(value)));
    if (result != howManyDigits)
    {
        System.Console.WriteLine($"Ошибка: введено число не содержащее {howManyDigits} цифр.");
        return false;
    }
    return true;
}

int ReverseNumber(int value) // функция выдает перевернутое число
{
    int reverse = 0;
    while (value > 0)
    {
        reverse = reverse * 10 + value % 10;
        value = value / 10;
    }
    return reverse;
}

int number = InputInt($"Введите пятизначное число");
if (ValidateValue(number))
{
    if (number == ReverseNumber(number))
    {
        System.Console.WriteLine($"{number} является палиндромом");
    }
    else
    {
        System.Console.WriteLine($"{number} не палиндром");
    }
}