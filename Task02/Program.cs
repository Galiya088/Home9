// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int numFirst = GetNum("Введите  M: ");
int numSecond = GetNum("Введите  N: ");

int GetNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int naturalSum(int mnumFirst, int numSecond)
{
    if (numFirst == numSecond)
        return numSecond;
    return numSecond + naturalSum(numFirst, numSecond - 1);
}

Console.WriteLine($"Сумма элементов от {numFirst} до {numSecond} = {naturalSum(numFirst, numSecond)}");