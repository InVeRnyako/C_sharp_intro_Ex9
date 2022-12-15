// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int m = GetIntNatFromUser("Введите значение m: ");
int n = GetIntNatFromUser("Введите значение n: ");

Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {Ackermann(m,n)}");

static int Ackermann(int m, int n)
{
    if (m == 0)
        return n+1;
    if (n == 0)
        return Ackermann(m - 1, 1);
    else
        return Ackermann(m - 1, Ackermann(m, n - 1));
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