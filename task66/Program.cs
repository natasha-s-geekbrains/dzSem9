// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int startNumber = GetNumber("Введите начальное натуральное число M: ");
int finishNumber = GetNumber("Введите конечное натуральное число N > первого числа: "); // это условие видно в двух примерах к задаче
if (finishNumber <= startNumber)
{
    Console.Write("Второе число должно быть больше первого. Повторите ввод.");
}
int Sum = 0;
int resultSum = GetSum(startNumber, finishNumber);
Console.Write($"Cумма натуральных элементов в промежутке от {startNumber} до {finishNumber} => {resultSum}");

int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

int GetSum(int startNum, int finishNum)
{
    if (finishNum >= startNum)
    {
        return Sum + startNum + GetSum(startNum + 1, finishNum);
    }
    else 
    {
        return 0;
    }
}

