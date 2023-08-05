// Задача 64: Задайте значение N. Напишите программу,
//которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int startNum = GetNum("Введите значение N: ");
int lastNumber = 1;
Console.Write('"');
Console.Write($"{GetReversedRow(startNum)}");

int GetNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

string GetReversedRow(int firstNumber)
{
    if (firstNumber > lastNumber)
    {
        return firstNumber + ", " + GetReversedRow(firstNumber - 1);
    }
    else
    {
        return $"{lastNumber}" + '"';
    }

}