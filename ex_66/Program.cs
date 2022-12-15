// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120

int m = GetIntNatFromUser("Введите значение M: ");
int n = GetIntNatFromUser("Введите значение N: ");

Console.Write($"M = {m}; N = {n} -> ");
SwapIfSecondNumIsMore(ref m, ref n);
Console.Write(SumBetweenTwoNumbers(n, m, 0));

static int SumBetweenTwoNumbers(int first, int second, int sum)
{
    if (first > second)
        return sum;
    return SumBetweenTwoNumbers(first + 1, second, sum + first);
}


static void SwapIfSecondNumIsMore(ref int first, ref int second)
{
    if (second > first)
    {    
        int temp = first;
        first = second;
        second = temp;
    }
    return;
}

int GetIntNatFromUser(string userMsg)
{
    while(true)
    {
        Console.Write(userMsg);
        if (int.TryParse(Console.ReadLine(), out int num))
            if (num >0)
                return num;
        Console.WriteLine("Ошибка ввода!");
    }
}