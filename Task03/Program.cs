// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int GetNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int AkkermanFunc(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return AkkermanFunc(m - 1, 1);
    else
        return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}


int numM = GetNum("Введите число M: ");
int numN = GetNum("Введите число N: ");

int Akkerman = AkkermanFunc(numM, numN);

Console.Write($"m = {numM}, n = {numN} -> A({numM},{numN}) = {Akkerman}");

